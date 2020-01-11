#!/bin/bash

if test $# -lt 1; then
    echo "usage: $0 <keyname> [common-name] [ip0] [ip1]..."
    exit 1
fi

KEY_NAME=$1
shift

if test $# -gt 0; then
    CANONICAL_SERVER_NAME=$1
    shift
else
    CANONICAL_SERVER_NAME=localhost
fi

mkdir -p secrets

echo "Using canonical name: $CANONICAL_SERVER_NAME"

# Note: the passwords are only set temporarily (openssl doesn't seem to let you generate without them)

if ! test -f secrets/ca.crt; then

    cat > secrets/ca.csr.conf <<- EOF
    [req]
    default_bits        = 2048
    prompt              = no
    distinguished_name  = req_distinguished_name

    [req_distinguished_name]
    C                   = UK
    L                   = London
    O                   = Test
    OU                  = Test
    CN                  = TestRootCA
EOF

    echo "Generate CA certificate:"
    openssl req \
        -x509 \
        -nodes \
        -days 36500 \
        -newkey rsa:2048 \
        -keyout secrets/ca.key \
        -out secrets/ca.crt \
        -config secrets/ca.csr.conf
fi

echo "Generate key signing request:"

cat > secrets/${KEY_NAME}.csr.conf <<- EOF
[req]
default_bits        = 2048
prompt              = no
distinguished_name  = req_distinguished_name
req_extensions      = req_ext

[req_distinguished_name]
C                   = UK
L                   = London
O                   = Test
OU                  = Test
CN                  = $CANONICAL_SERVER_NAME

[req_ext]
subjectAltName      = @alt_names

[alt_names]
DNS.1 = $CANONICAL_SERVER_NAME
EOF

IP_NUM=2
while [ $# -gt 0 ]
do
    echo "IP.$IP_NUM = $1">>secrets/${KEY_NAME}.csr.conf
    shift
    IP_NUM=$((IP_NUM+1))
done

openssl genrsa -out secrets/${KEY_NAME}.key 2048

openssl req \
    -new -sha256 \
    -key secrets/${KEY_NAME}.key \
    -out secrets/${KEY_NAME}.csr \
    -config secrets/${KEY_NAME}.csr.conf

echo "Self-sign secrets/${KEY_NAME}.crt certificate:"
openssl x509 -req \
    -passin pass:1111 \
    -days 365 \
    -in secrets/${KEY_NAME}.csr \
    -CA secrets/ca.crt \
    -CAkey secrets/ca.key \
    -set_serial 01 \
    -out secrets/${KEY_NAME}.crt \
    -extensions req_ext \
    -extfile secrets/${KEY_NAME}.csr.conf

echo "Remove passphrase from server key:"
openssl rsa -passin pass:1111 -in secrets/${KEY_NAME}.key -out secrets/${KEY_NAME}.key

openssl x509 -in secrets/${KEY_NAME}.crt -text -ext subjectAltName

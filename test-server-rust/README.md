Make sure to have latest 1.40 rustc compiler

https://www.rust-lang.org/tools/install
```
rustup update stable
```

E.g. run like

```bash
RUST_LOG=trace cargo run
```

or with TLS:
```bash
RUST_LOG=trace USE_TLS=1 cargo run
```
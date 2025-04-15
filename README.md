[![.NET](https://github.com/aimenux/NetArchTestDemo/actions/workflows/ci.yml/badge.svg?branch=master)](https://github.com/aimenux/NetArchTestDemo/actions/workflows/ci.yml)

# NetArchTestDemo
```
Using NetArchTest library to enforce architecture rules
```

In this demo, i m using [NetArchTest](https://github.com/BenMorris/NetArchTest) library in order to check layers dependencies :
- `Api` depends on `Application` and `Infrastructure`
- `Infrastructure` depends on `Application`
- `Application` depends on `Domain`
- `Domain` depends on nothing

**`Tools`** : net 9.0, netarchtest, nunit
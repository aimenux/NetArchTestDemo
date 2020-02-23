![.NET Core](https://github.com/aimenux/NetArchTestDemo/workflows/.NET%20Core/badge.svg)
# NetArchTestDemo
```
Using NetArchTest library to enforce architecture rules
```

In this demo, i m using [NetArchTest](https://github.com/BenMorris/NetArchTest) library in order to check layers dependencies :
- `Api` depends on `Domain` and `Infrastructure`
- `Infrastructure` depends on `Domain`
- `Domain` depends on nothing

**`Tools`** : vs19, net core 3.1
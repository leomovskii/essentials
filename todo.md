# Shaders
* Outline Shader (SRP)
* Blur Shader (SRP)
* Other

# Documenting
* Add xml comments
* Add Math2 info&examples to code-utilities readme
* Make 1.3 release with nice documented changelist

# Attributes

## Unit
Adds a prefix to the inspector's numeric field indicating the units used.

``` cshasrp
[Unit("m"), SerializeField] private float _SomeLength = 5;
[Unit("m^2"), SerializeField] private float _SomeArea = 34;
[Unit("L"), SerializeField] private float _SomeVolume = 100;
```

![image](https://github.com/user-attachments/assets/4914dd9c-69c4-48b8-a84a-d58faccffd8a)

### InfoBox (probably HelpBox)

![image](https://github.com/user-attachments/assets/e68e26b2-cb85-4d7e-af40-a8ebef11d990)

![image](https://github.com/user-attachments/assets/8fac71ba-308b-4235-ba0a-c14a76f712bb)

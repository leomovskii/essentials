# Flags
Used to add multi-select flags capability for an enum inspector field. Example:
```
// definition
public enum Options {
	Option1 = 1 << 0,
	Option2 = 1 << 1,
	Option3 = 1 << 2,
	Option4 = 1 << 3
}

// using
[Flags, SerializeField] private Options _options;
```

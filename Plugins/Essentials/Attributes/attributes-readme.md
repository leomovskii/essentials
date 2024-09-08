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
![image](https://github.com/user-attachments/assets/e02e07f2-4a87-4d84-82bc-8ded2fc6a41c)

# MinMax
Used to replace 'x' and 'y' in Vector2 and Vector2Int names with Min and Max respectively. Also constrains values ​​so that Max is never less than Min. Example:

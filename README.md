# ps-scripts
PowerShell automation scripts for routine tasks

## Templating

```
PS > . .\Templating.ps1
PS > CreateBy-Template <template-name> <component-name>
```

It takes files from `./templates` directory which starts with `template-name`.
Then it produces the component files within the working directory.
Each of the files will have the name `component-name` with the corresponding to the template extension.

### Example
```
PS > CreateBy-Template wtm-component my-component
```
Consider that we have three template files with the names:
```
wtm-component.html
wtm-component.scss
wtm-component.ts
```
It will produce three new files wihin the working directory:
```
my-component.html
my-component.scss
my-component.ts
```

## Template syntax
Templating uses string interpolation to produce component files.
So you can work with it as well as you do with usual string interpolation inside your script files.

For instance you might want to interpolate the value of some variable:
```
<require from="$PathToFile"></require>
```
... or execute some function:
```
export class $(CebabToCamelCase($Name)) extends BasePageComponent {
```

## Special template variables
There are some special variables and functions available from the template:
* `$Name` - a name of the component
* `CebabToCamelCase(str)` - converts `str` from cebab-case to CamelCase

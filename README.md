# 06_Types_of_variables
### These are the types of variables, but we now cover only 3.
 - Local variables
 - Instance variables or Non – Static Variables
 - Static Variables or Class Variables
 - Constant Variables
 - Readonly Variables
###  1-Local variables or Automatic variable
Local variable is defined in a method. We also call it "automatic variable" because it automatically created when the method is called 

```
public string Greating(string hi){
  string me = "there!";             # 'me' is local variable who create inside 'Greating' method
  return hi + me;
}

```
###  2-Instance variable
Instance variable is defined in a class but outside any method 

```
public string strName;        # Instance variable
public float fltAge;          # Instance variable

public string Greating(string hi){
  console.writeline("Hello"+me);
}

```

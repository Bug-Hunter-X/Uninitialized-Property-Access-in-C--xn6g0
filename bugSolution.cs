public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        // Now MyProperty is guaranteed to be initialized
        int value = MyProperty * 2; 
    }

    //Another solution, adding a check for null or zero
    public void MyMethod2(){
        int value = MyProperty == 0 ? 0 : MyProperty * 2; //Added a null or zero check
    }
}
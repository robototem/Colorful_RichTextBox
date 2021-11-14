# Colorful_RichTextBox
**This code can be used to print colorful messages in RichTextBox in WindowsFormApplications.**

![image](https://user-images.githubusercontent.com/84636881/141698105-391c4f9d-8ee1-4d47-833e-3f2ea263e227.png)

When calling the "Log" fuction, message code should be declared. So the color of text will change according to it.

For example:

```ruby
Log("(1000) This is an ERROR message.");
```

```ruby
private void Log(string mymessage)
{
    // (1000) ERROR message
    // (2000) SUCCESS message
    // (1002) OTHER messages
    if (mymessage.Substring(0, 6) == "(1000)")
    {
        string newmessage = DateTime.Now + ": " + mymessage + "\n";

        richTextBox1.Select(richTextBox1.TextLength, newmessage.Length);
        richTextBox1.SelectionColor = Color.Red;
        richTextBox1.AppendText(newmessage);

    }
 }
 ```

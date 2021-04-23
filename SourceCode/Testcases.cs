[Test]
public void TransformColorName()
{
    Assert.IsTrue(S2SConverter.GetColor("White").Equals("ffffffff"));
    Assert.IsTrue(S2SConverter.GetColor("Black").Equals("ff000000"));
    Assert.IsTrue(S2SConverter.GetColor("Blue").Equals("ff0000FF"));
    Assert.IsTrue(S2SConverter.GetColor("Black").Equals("ff000000"));
}

[Test]
public void TransformColor()
{
    Assert.IsTrue(S2SConverter.GetColor("#123").Equals("ff112233"));
    Assert.IsTrue(S2SConverter.GetColor("123").Equals("ff112233"));

    Assert.IsTrue(S2SConverter.GetColor("#1234").Equals("11223344"));
    Assert.IsTrue(S2SConverter.GetColor("1234").Equals("11223344"));

    Assert.IsTrue(S2SConverter.GetColor("#ffffff").Equals("ffffffff"));
    Assert.IsTrue(S2SConverter.GetColor("ffffff").Equals("ffffffff"));

    Assert.IsTrue(S2SConverter.GetColor("#ffffffff").Equals("ffffffff"));
    Assert.IsTrue(S2SConverter.GetColor("ffffffff").Equals("ffffffff"));
}

[Test]
public void TransformInvalidTextTrowsException()
{
    Assert.Throws<ArgumentException>(
        () => { S2SConverter.GetColor("Test"); });

    Assert.Throws<ArgumentException>(
        () => { S2SConverter.GetColor("TestTest"); });

    Assert.Throws<ArgumentException>(
    () => { S2SConverter.GetColor("#TestTest"); });

     Assert.Throws<ArgumentException>(
    () => { S2SConverter.GetColor(string.Empty); });
}
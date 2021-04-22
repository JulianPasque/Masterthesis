[Test]
public void TransformColorName()
{
    Assert.IsTrue(S2SConverter.GetColor("White").Equals("ffffffff"));
}
[Test]
public void Transform3DigitColorWithHash()
{
    Assert.IsTrue(S2SConverter.GetColor("#123").Equals("ff112233"));
    Assert.IsTrue(S2SConverter.GetColor("123").Equals("ff112233"));
}
[Test]
public void Transform4DigitColorWithHash()
{
    Assert.IsTrue(S2SConverter.GetColor("#1234").Equals("11223344"));
    Assert.IsTrue(S2SConverter.GetColor("1234").Equals("11223344"));
}
[Test]
public void Transform6DigitColorWithHash()
{
    Assert.IsTrue(S2SConverter.GetColor("#ffffff").Equals("ffffffff"));
    Assert.IsTrue(S2SConverter.GetColor("ffffff").Equals("ffffffff"));
}
[Test]
public void Transform8DigitColorWithHash()
{
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
}
[Authorize]
[HttpGet]
public IActionResult GetProducts()
{
    return Ok(new List<string>
    {
        "Laptop",
        "Mouse",
        "Keyboard"
    });
}

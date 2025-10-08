class tests
{
   public async Task CreateTopic_ValidInput_ShouldReturnSuccess()
    {
        var client = new HttpClient(); // Or use WebApplicationFactory for in-memory testing
        var topic = new { Title = "Microservices", Description = "Intro to distributed systems" };
        var response = await client.PostAsJsonAsync("https://localhost:5001/api/topics", topic);
        Assert.True(response.IsSuccessStatusCode);
    }
}
private void button1_Click(object sender, EventArgs e)
{
    var token = "!!! 換成你的Token!!!";
    var AdminUserId = "!!! 換成你的UserId!!!";
    isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);

    bot.PushMessage(AdminUserId, "測試訊息");
}

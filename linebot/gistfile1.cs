const string token = ""; //換成你的token
const string AdminUserId = ""; //換成你的UserId

//發送貼圖鈕
private void button2_Click(object sender, EventArgs e)
{
    isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);
    //發送貼圖
    bot.PushMessage(AdminUserId, 1,2);
}

//發送圖片鈕
private void button3_Click(object sender, EventArgs e)
{
    isRock.LineBot.Bot bot = new isRock.LineBot.Bot(token);

    //指定圖片位置
    Uri imgURL = new Uri("https://arock.blob.core.windows.net/blogdata201706/22-124357-ad3c87d6-b9cc-488a-8150-1c2fe642d237.png");
    //發送圖片
    bot.PushMessage(AdminUserId,imgURL);
}

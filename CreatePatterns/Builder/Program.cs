class Program
{
	static void Main(string[] args)
	{
		
		Baker bakerController = new Baker();
		// Создать письмо на отправку заказа
		MailBuilder builderPut = new PutMailBuilder();
		Mail putMail = bakerController.Bake(builderPut);
		Console.WriteLine(putMail.ToString());

		// Создать письмо получения товара на склад
		MailBuilder builderGet = new GetMailBuilder();
		Mail getMail = bakerController.Bake(builderGet);
		Console.WriteLine(getMail.ToString());


		// Создаем письмо реклама
		MailBuilder builderSpam = new SpamMailBuilder();
		Mail spamMail = bakerController.Bake(builderSpam);
		Console.WriteLine(spamMail.ToString());

		Console.Read();
	}
}

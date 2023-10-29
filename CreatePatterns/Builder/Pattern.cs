
using System.Text;

class Title
{
	// какого сорта мука
	public string titleName { get; set; }
}

class Source
{
	public string sourceValue { get; set; }
}

class Context
{
	public string contextValue { get; set; }
}

class Mail
{
	public Title title { get; set; }
	// соль
	public Source source { get; set; }

	public Context context { get; set; }
	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();

		if (title != null)
			sb.Append("Заголовок письма: "+title.titleName + "\n");
		if (source != null)
			sb.Append("Кому отправляем: "+source.sourceValue);
		if (context != null)
			sb.Append("Содержание: " + context.contextValue + " \n");
		return sb.ToString();
	}
}

// абстрактный класс строителя
abstract class MailBuilder
{
	public Mail mail { get; private set; }
	public void CreateMail()
	{
		mail = new Mail();
	}
	public abstract void SetTitle();
	public abstract void SetSource();
	public abstract void SetContext();
}

class Baker
{
	public Mail Bake(MailBuilder MailBuilder)
	{
		MailBuilder.CreateMail();
		MailBuilder.SetTitle();
		MailBuilder.SetSource();
		MailBuilder.SetContext();
		return MailBuilder.mail;
	}
}

class PutMailBuilder : MailBuilder
{
	public override void SetTitle()
	{
		this.mail.title = new Title { titleName = "Заказ сформтироват" };
	}

	public override void SetSource()
	{
		this.mail.source = new Source();
	}

	public override void SetContext()
	{
		this.mail.context = new Context();
	}
}

class GetMailBuilder : MailBuilder
{
	public override void SetTitle()
	{
		this.mail.title = new Title { titleName = "Заказ сформтироват" };
	}

	public override void SetSource()
	{
		this.mail.source = new Source { sourceValue = "ООО Нефть" }; ;
	}

	public override void SetContext()
	{
		this.mail.context = new Context { contextValue = "Товар на складе" }; ;
	}
}

class SpamMailBuilder : MailBuilder
{
	public override void SetTitle()
	{
		this.mail.title = new Title { titleName = "Новые акции для Вас" };
	}

	public override void SetSource()
	{
		this.mail.source = new Source { sourceValue = "ООО ОЗОН" }; ;
	}

	public override void SetContext()
	{
		this.mail.context = new Context { contextValue = "Товар по низкой цене. ТВ за 5000 руб" }; ;
	}
}
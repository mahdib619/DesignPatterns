using Builder.Builders;
using Builder.Product;

namespace Builder.Director;

internal class ApplicationPageDirector
{
	private readonly IApplicationPageBuilder builder;

	public ApplicationPageDirector(IApplicationPageBuilder builder)
	{
		this.builder = builder;
	}

	public ApplicationPage CreateEmployeeForm()
	{
		builder.AddLabel("Employee Form");

		AddBasicForm();

		builder.DesignBody()
			.AddLabel("Field")
			.AddTextbox();

		AddSubmitCancelButton();
		AddDefaultFooter();

		return builder.Create();
	}

	public ApplicationPage CreateStudentForm()
	{
		builder.AddLabel("Student Form");

		AddBasicForm();

		builder.DesignBody()
			.AddLabel("Grade")
			.AddTextbox();

		AddSubmitCancelButton();
		AddDefaultFooter();

		return builder.Create();
	}

	private void AddBasicForm()
	{
		builder.DesignBody()
			.AddLabel("FirstName")
			.AddTextbox()
			.AddLabel("LastName")
			.AddTextbox()
			.AddLabel("Age")
			.AddTextbox();
	}

	private void AddSubmitCancelButton()
	{
		builder.DesignBody()
			.AddLine(30)
			.AddButton("Submit")
			.AddButton("Cancel");
	}

	private void AddDefaultFooter()
	{
		builder.DesignFooter()
			.AddLabel("created by mahdi.");
	}
}

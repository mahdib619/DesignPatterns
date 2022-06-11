using Adapter.Adapter;
using Adapter.Core.Services;

ISchoolService schoolService = new SchoolService(new LibBarCharPrinterAdapter());

schoolService.SignupStudent("Ghasem", "first");
schoolService.SignupStudent("Akbar", "first");
schoolService.SignupStudent("Rassol", "first");

schoolService.SignupStudent("Naser", "second");
schoolService.SignupStudent("Abdolla", "second");
schoolService.SignupStudent("Rashid", "second");

schoolService.PrintStates();
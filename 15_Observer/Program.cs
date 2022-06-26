using P05_Observer;

var data = new DataSource();

var pie = new PieChart(data);
var spreadSheet = new SpreadSheet(data);

data.AddObserver(pie);
data.AddObserver(spreadSheet);

data.Value = "fffff";
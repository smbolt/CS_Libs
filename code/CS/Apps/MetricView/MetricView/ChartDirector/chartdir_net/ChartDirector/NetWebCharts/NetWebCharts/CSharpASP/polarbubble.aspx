<%@ Page Language="C#" Debug="true" %>
<%@ Import Namespace="ChartDirector" %>
<%@ Register TagPrefix="chart" Namespace="ChartDirector" Assembly="netchartdir" %>

<!DOCTYPE html>

<script runat="server">

//
// Page Load event handler
//
protected void Page_Load(object sender, EventArgs e)
{
    // The data for the chart
    double[] data0 = {6, 12.5, 18.2, 15};
    double[] angles0 = {45, 96, 169, 258};
    double[] size0 = {41, 105, 12, 20};

    double[] data1 = {18, 16, 11, 14};
    double[] angles1 = {30, 210, 240, 310};
    double[] size1 = {30, 45, 12, 90};

    // Create a PolarChart object of size 460 x 460 pixels
    PolarChart c = new PolarChart(460, 460);

    // Add a title to the chart at the top left corner using 15pt Arial Bold Italic font
    c.addTitle2(Chart.TopLeft, "<*underline=2*>EM Field Strength", "Arial Bold Italic", 15);

    // Set center of plot area at (230, 240) with radius 180 pixels
    c.setPlotArea(230, 240, 180);

    // Use alternative light grey/dark grey circular background color
    c.setPlotAreaBg(0xdddddd, 0xeeeeee);

    // Set the grid style to circular grid
    c.setGridStyle(false);

    // Add a legend box at the top right corner of the chart using 9pt Arial Bold font
    c.addLegend(459, 0, true, "Arial Bold", 9).setAlignment(Chart.TopRight);

    // Set angular axis as 0 - 360, with a spoke every 30 units
    c.angularAxis().setLinearScale(0, 360, 30);

    // Set the radial axis label format
    c.radialAxis().setLabelFormat("{value} km");

    // Add a blue (0x9999ff) line layer to the chart using (data0, angle0)
    PolarLineLayer layer0 = c.addLineLayer(data0, 0x9999ff, "Cold Spot");
    layer0.setAngles(angles0);

    // Disable the line by setting its width to 0, so only the symbols are visible
    layer0.setLineWidth(0);

    // Use a circular data point symbol
    layer0.setDataSymbol(Chart.CircleSymbol, 11);

    // Modulate the symbol size by size0 to produce a bubble chart effect
    layer0.setSymbolScale(size0);

    // Add a red (0xff9999) line layer to the chart using (data1, angle1)
    PolarLineLayer layer1 = c.addLineLayer(data1, 0xff9999, "Hot Spot");
    layer1.setAngles(angles1);

    // Disable the line by setting its width to 0, so only the symbols are visible
    layer1.setLineWidth(0);

    // Use a circular data point symbol
    layer1.setDataSymbol(Chart.CircleSymbol, 11);

    // Modulate the symbol size by size1 to produce a bubble chart effect
    layer1.setSymbolScale(size1);

    // Output the chart
    WebChartViewer1.Image = c.makeWebImage(Chart.PNG);

    // Include tool tip for the chart
    WebChartViewer1.ImageMap = c.getHTMLImageMap("", "",
        "title='{dataSetName} at ({value} km, {angle} deg)\nStrength = {z} Watt'");
}

</script>

<html>
<head>
    <title>Polar Bubble Chart</title>
</head>
<body style="margin:5px 0px 0px 5px">
    <div style="font:bold 18pt verdana">
        Polar Bubble Chart
    </div>
    <hr style="border:solid 1px #000080" />
    <div style="font:10pt verdana; margin-bottom:1.5em">
        <a href='viewsource.aspx?file=<%=Request["SCRIPT_NAME"]%>'>View Source Code</a>
    </div>
    <chart:WebChartViewer id="WebChartViewer1" runat="server" />
</body>
</html>


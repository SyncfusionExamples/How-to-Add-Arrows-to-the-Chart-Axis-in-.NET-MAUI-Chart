# How to Add Arrows to the Chart Axis in .NET MAUI Chart
This article provides a detailed walkthrough on how to add arrows to the axis using Annotations in [.NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts).

The [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html) includes support for [ Annotations](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html#Syncfusion_Maui_Charts_SfCartesianChart_Annotations), enabling the addition of various types of annotations to enhance chart visualization. Using [Line Annotation](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LineAnnotation.html) for you can achieves to add arrows to the axis.

The Line Annotation includes following property:
* [X1](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAnnotation.html#Syncfusion_Maui_Charts_ChartAnnotation_X1) - Gets or sets the X1 coordinate of the line annotation.
* [X2](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ShapeAnnotation.html#Syncfusion_Maui_Charts_ShapeAnnotation_X2) - Gets or sets the X2 coordinate of the line annotation.
* [Y1](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAnnotation.html#Syncfusion_Maui_Charts_ChartAnnotation_Y1) - Gets or sets the Y1 coordinate of the line annotation.
* [Y2](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ShapeAnnotation.html#Syncfusion_Maui_Charts_ShapeAnnotation_Y2) - Gets or sets the Y2 coordinate of the line annotation.
* [CoordinateUnit](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartAnnotation.html#Syncfusion_Maui_Charts_ChartAnnotation_CoordinateUnit) - Gets or sets the coordinate unit value for the line annotation.
* [LineCap](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LineAnnotation.html#Syncfusion_Maui_Charts_LineAnnotation_LineCap) - Gets or sets the line cap value for the line annotation.

Learn step-by-step instructions and gain insights to add arrows to the axis using annotations.

**Step 1:** Initialize the SfCartesianChart and add the series and legend to it as follows.

**XAML** 
 ```xml
<chart:SfCartesianChart>

    <chart:SfCartesianChart.Legend>
        <chart:ChartLegend/>
    </chart:SfCartesianChart.Legend>

    <chart:ColumnSeries ItemsSource="{Binding ElectronicsSales}"
            XBindingPath="Month"
            YBindingPath="Sales"
            EnableTooltip="True"
            EnableAnimation="True"
            Label="Electronic Sales">
    </chart:ColumnSeries>

    <chart:ColumnSeries ItemsSource="{Binding FurnitureSales}"
            XBindingPath="Month"
            YBindingPath="Sales"
            EnableTooltip="True"
            EnableAnimation="True"
            Label="Furniture Sales">
    </chart:ColumnSeries>

</chart:SfCartesianChart> 
 ```
 
**Step 2:** Initialize the LineAnnotation within the Annotations collection of the SfCartesianChart, configure it to align with the desired axis, and use the LineCap property to add arrows to the line annotation.

**XAML** 

 
 ```xml
<chart:SfCartesianChart>

    <chart:SfCartesianChart.XAxes>
        <chart:CategoryAxis PlotOffsetStart="7" PlotOffsetEnd="17">
            .....
        </chart:CategoryAxis>
    </chart:SfCartesianChart.XAxes>

    <chart:SfCartesianChart.YAxes>
        <chart:NumericalAxis Minimum="0" Maximum="30000" Interval="10000" PlotOffsetEnd="10" PlotOffsetStart="7">
            .....
        </chart:NumericalAxis>
    </chart:SfCartesianChart.YAxes>

    <chart:SfCartesianChart.Annotations>
        <chart:LineAnnotation CoordinateUnit="Axis" X1="-0.5" X2="5.6" Y1="0" Y2="0" Stroke="Black" LineCap="Arrow" StrokeWidth="2"/>
        <chart:LineAnnotation CoordinateUnit="Axis" X1="-0.5" X2="-0.5" Y1="0" Y2="30000" Stroke="Black" LineCap="Arrow" StrokeWidth="2"/>
    </chart:SfCartesianChart.Annotations>

</chart:SfCartesianChart> 
 ```
 
**Output:**

![AddArrowtoAnnotation](https://github.com/user-attachments/assets/f04a677f-95fa-4cb4-89ed-a62760956175)


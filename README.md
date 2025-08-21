# How to handle the tapped Xamarin.Forms listview tapped event when child view is clicked in Android platform?
This example demonstrates how to handle the interaction event for the child view in Android Renderer.

## Sample

```xaml
 <sync:SfListView x:Name="listView" ItemSize="120" TapCommand="{Binding TapCommand}"
                ItemsSource="{Binding BookInfo}">
    <sync:SfListView.Behaviors>
        <local1:Behaviours/>
    </sync:SfListView.Behaviors>
    <sync:SfListView.ItemTemplate>
        <DataTemplate>
            <Grid Padding="10" BackgroundColor="Aqua">
                <Grid.GestureRecognizers>
                    <TapGestureRecognizer Command="{Binding Path = BindingContext.GestureCommand, Source={x:Reference listView}}"/>
                </Grid.GestureRecognizers>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="*" />
                    <ColumnDefinition Width="100" />
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition Height="0.4*" />
                    <RowDefinition Height="0.6*" />
                </Grid.RowDefinitions>
                <Label Text="{Binding BookName}" FontAttributes="Bold"/>
                <Button Text="Test" Command="{Binding BindingContext.ButtonCommand, Source={x:Reference listView}}"  Grid.Row="1"/>
                <!--<Label Grid.Row="1" Text="{Binding BookDescription}" FontSize="15"/>-->
                <!--<numeric:SfNumericUpDown Grid.Column="1" Grid.RowSpan="2" HorizontalOptions="Start" VerticalOptions="Center"/>-->
            </Grid>
        </DataTemplate>
    </sync:SfListView.ItemTemplate>
</sync:SfListView>
```

See [How to handle the tapped event when child view is clicked in Android platform](https://www.syncfusion.com/kb/9536/how-to-handle-the-tapped-event-when-child-view-is-clicked-in-android-platform) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

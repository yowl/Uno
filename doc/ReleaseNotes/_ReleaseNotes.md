# Release notes

## Next version

### Features

### Breaking Changes

### Bug fixes

## Release 1.44.0

### Features
* Add support for `ICollectionView.CopyTo`
* Add support for `ViewBox`
* Add support for `AutoSuggestBox.ItemsSource`
* Add support for `Selector.SelectedValuePath` (e.g. useful for ComboBox)
* Add support for JS unhandled exception logging for CoreDispatcher (support for Mixed mode troubleshooting)
* [WASM] Improve element arrange and transform performance
* Restore original SymbolIcon.SymbolProperty as a C# property
* Add support for `MediaPlaybackList`
* Update Uno.SourceGenerationTasks to improve build performance
    - Move to the latest Uno.SourceGenerationTasks to improve project parsing performance, and allows for the removal of unused targets caused by nventive/Uno.SourceGeneration#2. Uno.Xaml and Uno.UI.BindingHelpers now only build the required targets.
    - Move to net461 for test projects so the the Uno.Xaml project can be referenced properly
    - Use the latest MSBuild.Sdk.Extras for actual parallel cross-targeted builds
    - Move the nuget package versions to the Directory.Build.targets file so it's easier to change all versions at once.
* Add support for NavigationView Top Navigation
* Adjust `SystemChromeMediumHighColor` to use the Light theme
* Add support for `FrameworkElement.GoToStateCore`
* Adjust `ListView` measure/arrange for dynamic content
* Add some missing default UWP styles
* The `FrameworkElement.IsLoaded` property is now public
* Improve XAML generation error messages for unknown symbols
* Added default console logging for all platforms
* Add support for `Application.OnWindowCreated`
* Added non-throwing stubs for `AutomationProperty`
* Add missing system resources
* Add support for x:Bind in StaticResources (#696)
* Add support for x:Name late binding support to adds proper support for CollectionViewSource in Resources (#696)
* `PointerRelease` events are now marked as handled by the `TextBox`
* `KeyDown` events that are changing the cursor position (left/right/top/bottom/home/end) are now marked as handled by the `TextBox`
* `RoutedEventArgs.IsGenerated` returns `false` as generating events with Uno is not yet supported
* `AutomationPeer.ListenerExists` returns `false` as we cannot generating events with Uno is not yet supported
* `KeyUp` event properly sends `KeyEventArgs` to the controls
* Add ItemsSource CollectionViewSource update support (#697)
* Add support for the `CollectionViewSource.ItemsPath` property
* Fixed support for dots in resource names (#700)
* Add support for `BindingExpression.UpdateSource()`
* Updated Android version to target Android 9.0
* The CI validates for API breaking changes
* Added samples application BenchmarkDotNet support.

### Breaking changes
* Make `UIElement.IsPointerPressed` and `IsPointerOver` internal
* You will not be able to build projects targeting Android 8.0 locally anymore. Change your Android target to Android 9.0 or replace MonoAndroid90 by MonoAndroid80 in the TargetFrameworks of your projects files.
* 1.43.1 breaking changes rollback to 1.42.0:
    - `ObservableVector<T>` is now internal again
    - `TimePicker.Time` and `TimePicker.MinuteIncrement` are now back for `netstandard2.0`
    - `MediaPlaybackItem.Source` is back as a readonly property
    - `MediaPlaybackList.Items` is back to an `IObservableVector`

### Bug fixes
 * Transforms are now fully functionnal
 * [Wasm] Fixed ListView infinite loop when using custom containers
 * [Wasm] Use Uno.UI Assembly for namespace type lookup in `XamlReader`
 * [Wasm] Fixed `System.UriConverter` is being linked out
 * 145075 [Android] [Wasm] Android and Wasm don't match all specific UWP behaviors for the Image control.
 * [Wasm] Don't fail if the dispatcher queue is empty
 * 146648 [Android] fixed ListView grouped items corruption on scroll
 * [Wasm] Fix `ListView` recycling when the `XamlParent` is not available for `AutoSuggestBox`
 * 147405 Fix NRE on some MediaTransportControl controls
 * #139 Update Uno.SourceGenerationTasks to improve build performance
 * Update `Uno.UI.Toolkit` base UWP sdk to 17763
 * [Wasm] Fixes items measured after being removed from their parent appear in the visual tree, on top of every other items.
 * [Wasm] Fixes lements may not be removed form the global active DOM elements tracking map
 * [Wasm] Disable the root element scrolling (bounce) on touch devices
 * Fixed invalid iOS assets folder. `ImageAsset` nodes must not be `<Visible>false</Visible>` to be copied to the generated project.
 * Make CollectionViewSource.View a proper DependencyProperty (#697)
 * Fixed support for string support for `Path.Data` (#698)
 * 150018 Fix nullref in `Pivot` when using native style
 * 149312 [Android] Added `FeatureConfiguration.NativeListViewBase.RemoveItemAnimator` to remove the ItemAnimator that crashes when under stress
 * 150156 Fix `ComboBox` not working when using `Popover`.

## Release 1.43.1

### Features
* [Wasm] Improve general performance and memory pressure by removing Javascript interop evaluations.
* Add support for Windows 10 SDK 17763 (1809)
* Improve the Uno.UI solution memory consumption for Android targets
* Add support for GridLength conversion from double
* Raise exceptions on missing styles in debug configuration
* Add working ViewBox stub
* `Path.Data` property now invalidates measure and arrange
* Wasm `Image` logs Opened and Failed events
* Add UpToDateCheckInput to avoid VS invalid incremental rebuilds
* 35178 Added recipe for copying text to clipboard
* Added ToogleSwitch documentation in Uno/Doc/Controls.
* Added new properties for ToggleSwitch Default Native Styles.
  [iOS] For BindableUISwitch : TintColorBrush property was added to be able to tint the outline of the switch when it is turned off.
  [Android] For BindableSwitchCompat : - Text property was added in order to change the ToggleSwitch label.
                                       - TextColor property was added in order to change the ToggleSwitch label color.
                                       - ThumbTint property was added in order to change the Thumb color.
                                       - TrackTint property was added in order to change the Track color.
* Samples apps now contain a Unit Tests page
* Added missing resources for NavigationViewItem
* All Nuget and VSIX artifacts are now Authenticode signed
* Resource strings are now loaded from `upri` files for faster resolution
* Add `FeatureConfiguration.Interop.ForceJavascriptInterop` to enable JS Eval fallback in Wasm mode.
* Add support for 1809 NavigationView
* Add support for runtime conversion of global static resources unknown at compile time
* Fixed fallback support for Style property set via ThemeResource
* Add support for multiple resw folders with upri resource generation
* Add support for `ThicknessHelper`
* ResourceLoader adjustments …
  * CurrentUICulture and CurrentCulture are set when setting ResourceLoader .DefaultCulture
  * upri load now ignores resources not used by the current culture
* Add BrushConverter support for Color input
* Add SplitView support for PaneOpened and PaneOpening
* Add CoreApplication.GetCurrentView() Dispatcher and TitleBar stubs support
* Add support for IsItemItsOwnContainer iOS ListView
* Add missing Android Sample App symbols font
* Add SampleControl for Samples app for easier browsing and UI Testing of samples
* Import Border samples
* Improve UIElement inner Children enumeration performance and memory usage
* Add `FeatureConfiguration.FrameworkElement.AndroidUseManagedLoadedUnloaded` to control the native or managed propagation performance of Loaded/Unloaded events through the visual tree
* Raise Application.UnhandledException event on failed navigation
* Adjusts the `Microsoft.NETCore.UniversalWindowsPlatform` version in the UWP head template to avoid assembly loading issues when using the Uno library template in the sample solution.
* [Android] Add support for ListViewItem instances provided via the ItemsSource property
* Added support to disable accessibility feature of larger text on iOS and Android by adjusting the FeatureConfiguration.Font.IgnoreTextScaleFactor flag. Please note that Apple [recommends to keep text sizes dynamic](https://developer.apple.com/videos/play/wwdc2017/245) for a variety of reasons and to allow users to adjust their text size preferences.
* [Wasm] Code for `Path.Stretch` has been moved to `Shape` and works well now for all shapes.
* Add support for `DynamicObject` data binding, to enable support for `Elmish.Uno`.
* Add support for VS2019 VSIX installation
* Improved Xaml generation speed, and incremental build performance
* [Wasm] Fix `CoreDispatcher` `StackOverflowException` when running on low stack space environments (e.g. iOS)
* Add support for `ResourceLoader.GetForViewIndependentUse(string)` and named resource files
* [Wasm] Load events are now raised directly from managed code. You can restore the previous behavior (raised from native) by setting `FeatureConfiguration.FrameworkElement.WasmUseManagedLoadedUnloaded = false`.
* Updated memory profiling documentation
* Updated default app template iOS GC settings
* Add support for WebAssembly Web Projects
* Add support for WebAssembly debugging with Chrome
* Add support for XAML `x:FieldModifier`
* Add Uno.UI linker definition files
* Adjust FlyoutPresenter default template
* Add support for Flyout anchor
* Improved XAML designer support
* Improved DependencyObject performance under AOT (JS dynCalls for overrides/delegates inside of EH blocks)
* Add support for MatrixTransform, UIElement.TransformToVisual now returns a MatrixTransform
* 140564 [Android] Added workaround for inverted ListView fling issue on Android P

### Breaking changes
* Refactored ToggleSwitch Default Native XAML Styles. (cf. 'NativeDefaultToggleSwitch' styles in Generic.Native.xaml)
  [iOS] For BindableUISwitch : Background property was changed for OnTintColorBrush and Foreground property for ThumbTintColorBrush.
  [Android] BindableSwitch was renamed BindableSwitchCompat in order to avoid confusion with the Switch control.
* Remove invalid Windows.UI.Xaml.Input.VirtualKeyModifiers
* Time picker flyout default styles has been changed to include done and cancel buttons
* DataTemplateSelector implementations are now called using the 2 parameters overload first with a fallback to the 1 parameter overload on null returned value.
  Old behavior could be restored using `FeatureConfiguration.DataTemplateSelector.UseLegacyTemplateSelectorOverload = true`.
* Using "/n" directly in the XAML for a text/content property is not supported anymore in order to match the UWP behavior. 
  You can use "&#x0a;" instead in the text/content properties or a carriage return where you need it in the localized resources.
* The `ResourcesGeneration` msbuild target has been renamed to `UnoResourcesGeneration`
  If your csproj is using this target explicily, change it to the new name.

### Bug fixes
 * MediaPlayerElement [iOS] Subtitles are not disable on initial launch anymore
 * MediaPlayerElement [Android]Player status is now properly updated on media end
 * MediaPlayerElement [Android]Fix issue when video metadata reports a width or height of 0
 * #388 Slider: NRE when vertical template is not defined
 * 138117 [Android] Removing a bookmarked/downloaded lesson can duplicate the assets of a different lesson.
 * [Wasm] Fix VirtualizingPanelAdapter measure and arrange
 * 137892 [Android] Fixed FontFamily, FontSize and FontWeight are not applied anymore on the TextBox's content.
 * Don't fail on empty grid ArrangeOverride
 * Don't generate the Bindable attribute if already present
 * Adjust .NET template projects versions to 4.6.1
 * Adjust Microsoft.CodeAnalysis versions to avoid restore conflicts
 * Fix element name matching existing types fails to compile (e.g. ContentPresenter)
 * 138735 [Android] Fixed broken DatePicker
 * Multi-selection Check Boxes in ListViewItems are appearing brielfly (https://github.com/nventive/Uno/issues/403)
 * 140721 [Android] FlipView not visible when navigating back to page
 * 138537 [iOS] App freezes after State selection causing infinite load on every subsequent launch
 * Fix invalid Border Content type for macOS
 * Don't fail iOS ListView if item Content is null
 * [Wasm] Implement naive refresh for items manipulation in the ListViewBase
 * 3326 [iOS][ItemsControl] ItemsControl in FlipView does not restore items properly
 * Fix NRE in Slider when no template is applied
 * Fix `Frame` does not unset `Page.Frame` when a page is removed
 * Add Wasm PlatformNotSupportedException for System.IO after CoreFX merge in mono
 * Border properties now invalidates measure and arrange on all platforms
 * 141907 [Android] [iOS] The toggle switch is half missing.
 * 142937 [Android] [iOS] Some Button ThemeBrushes are missing.
 * 143527 [Android] Fixed broken TimePicker Flyout on android devices.
 * 143596 [Wasm] Images stretching is incorrect
 * 143595 [Wasm] Wasm ListView Resizing is not working - Limitation: items can't change its size yet, but it's now getting measured/arranged correctly.
 * 143527 [Android] Fixed broken TimePicker Flyout on android devices.
 * 143598 [Wasm] Wasm Animation rotation center is incorrect
 * Fixes invalid parsing of custom types containing `{}` in their value (#455)
 * Add workaround for iOS stackoverflow during initialization.
 * Improve the file locking issues of Uno.UI.Tasks MSBuild task
 * Fix `VisibleBoundsPadding` memory leak
 * [ios] Time picker missing "OK" confirmation button
 * #87 / 124046 ComboBox incorrect behavior when using Items property
 * [Wasm] ComboBox wasn't working anymore since few versions
 * Fix memory leak with defining event handlers in XAML documents
 * Fix memory leak in `CommandBar`
 * Fix memory leak when using `x:Name` in XAML documents
 * 143170 [iOS] [WatermarkedDatePicker] When the Maxyear boundary is reached the first time, the calendar goes back two days instead of one
 * #491 DataTemplateSelector.SelectTemplate is not called on iOS and Android. The behavior is now closer to UWP.
 * 144268 / #493 : Resources outside of 'en' folder not working
 * Support for duplicate XAML `AutomationProperties.Name`
 * `ListViewBase.SelectedItems` is updated on selection change in Single selection mode
 * #528 ComboBoxes are empty when no datacontext
 * Ensure that Uno.UI can be used with VS15.8 and earlier (prevent the use of VS15.9 and later String APIs)
 * [Android] Listview Items stay visually in a pressed state,(can click multiple) when you click then scroll down, click another item, and scroll back up
 * 144101 fixed `ListView` group headers messed up on item update
 * #527 Fix for `Selector.SelectionChanged` is raised twice on updated selection
 * [iOS] Add fail-safe on `FrameworkElement.WillMoveToSuperview` log to `Application.Current.UnhandledException`

## Release 1.42

### Features
* Add base infrastructure platform for macOS
* 136259 Add a behavior so that tap makes controls fade out
* 135985 [Android], [iOS] ListViewBase Support [MultiSelectStates](https://msdn.microsoft.com/en-us/library/windows/apps/mt299136.aspx?f=255&MSPPError=-2147217396) on ListViewItem. This allows the item container to visually adapt when multiple selection is enabled or disabled.
* #325 Add support for `NavigationView` control
* Add support for `SymbolIcon` control for WebAssembly
* Add support for `UIElement.Clip` for WebAssembly
* Add support for inner-Uno.UI strings localization
* Add stubs for RichTextBlock
* Add `BitmapIcon` support
* Add `BitmapIcon.ShowAsMonochrome` support
* Add support for `Windows.Foundation.UniversalApiContract` in `IsApiContractPresent`
* Add support for ContentProperty on UserControl
* Add `DelegateCommand<T>`
* #131258 Added support for _RoutedEvents_. See [routed-events.md documentation](../articles/routed-events.md).
* [WASM] #234 Support virtualization in ListView

### Breaking changes
* 132002 [Android] The collapsible button bar is now taken into account by visible bounds calculation. Apps which use VisibleBoundsPadding or have command bars will therefore see an adjustment to the height of their windows on Android.

### Bug fixes
 * 135258 [Android] Fixed ImageBrush flash/flickering occurs when transitioning to a new page for the first time.
 * 131768 [iOS] Fixed bug where stale ScrollIntoView() request could overwrite more recent request
 * 136092 [iOS] ScrollIntoView() throws exception for ungrouped lists
 * 136199 [Android] TextBlock.Text isn't visually updated if it changes while device is locked
 * Fix Android and iOS may fail to break on breakpoints in `.xaml.cs` if the debugging symbol type is Full in projects created from templates
 * 136210 [Android] Path is cut off by a pixel
 * 132004 [Android] Window bounds incorrect for screen with rounded corners
 * #312 [Wasm] Text display was chopped on Wasm.
 * 135839 `WebView` No longer raises NavigationFailed and NavigationCompleted events when navigation is cancelled on iOS.
 * 136188 [Android] Page elements are aligned differently upon back navigation
 * 136114 [iOS] Image inside Frame doesn't respond to orientation changes
 * Fix crash when a `VisualState` does not have a valid `Name`
 * Adjust compiled binding application ordering when loading controls
 * Ensure the SplitView templated parent is propagated properly for FindName
 * Fix infinite loop when parsing empty Attached Properties on macOS
 * 137137 [iOS] Fixed `DatePickerSelector` not propagating coerced initial value
 * 103116 [iOS] Navigating to a _second_ local html file with `WebView` doesn't work.
 * 134573 CommandBar doesn't take the proper space on iOS phones in landscape
 * Image with partial size constraint now display properly under Wasm.
 * 138297 [iOS][TextBlock] Measurement is always different since we use Math.Ceiling
 * 137204 [iOS] ListView - fix bug where item view is clipped
 * 137979 [Android] Incorrect offset when applying RotateTransform to stretched view
 * Now supports internal object in desource dictionaries
 * 134573 CommandBar doesn't take the proper space on iOS phones in landscape
 * #26 The explicit property <Style.Setters> does not intialize style setters properly
 * 104057 [Android] ListView shows overscroll effect even when it doesn't need to scroll
 * #376 iOS project compilation fails: Can't resolve the reference 'System.Void Windows.UI.Xaml.Documents.BlockCollection::Add(Windows.UI.Xaml.Documents.Block)
 * 138099, 138463 [Android] fixed `ListView` scrolls up when tapping an item at the bottom of screen
 * 140548 [iOS] fixed `CommandBar` not rendering until reloaded
 * [147530] Add a missing `global::` qualifier in the `BindableMetadataGenerator`
 * [WASM] Add workaround for mono linker issue in AOT mode in `ObservableVectorWrapper`

## Release 1.41

### Features

* [#154](https://github.com/nventive/Uno/issues/154) Implement the MediaPlayerElement control
* 135799 Implemented MediaPlayer.Dispose()

### Bug fixes

 * 129762 - Updated Android SimpleOrientationSensor calculations based on SensorType.Gravity or based on single angle orientation when the device does not have a Gyroscope.
 * 134189 [iOS] The Time Picker flyout placement is not always respected
 * 134132 [Android] Fix loading of ItemsPresenter
 * 134104 [iOS] Fixed an issue when back swiping from a page with a collapsed CommandBar
 * 134026 [iOS] Setting a different DP from TextBox.TextChanging can cause an infinite 'ping pong' of changing Text values
 * 134415 [iOS] MenuFlyout was not loaded correctly, causing templates containing a MenuFlyout to fail
 * 133247 [iOS] Image performance improvements
 * 135192 [iOS] Fixed ImageBrush flash/flickering occurs when transitioning to a new page.
 * 135112 [Android] Fix crash in UpdateItemsPanelRoot() in the ItemsControl class.
 * 132014, 134103 [Android] Set the leading edge considering header can push groups out off the screen
 * 131998 [Android] Window bounds set too late
 * 131768 [iOS] Improve ListView.ScrollIntoView() when ItemTemplateSelector is set
 * 135202, 131884 [Android] Content occasionally fails to show because binding throws an exception
 * 135646 [Android] Binding MediaPlayerElement.Source causes video to go blank
 * 136093, 136172 [iOS] ComboBox does not display its Popup
 * 134819, 134828 [iOS] Ensures the back gesture is enabled and disabled properly when the CommandBar is visible, collapsed, visible with a navigation command and collapsed with a navigation command.
 * 137081 Xaml generator doesn't support setting a style on the root control
 * 148228 [Android] Right theme (clock or spinner) is selected for specific time increments 
 * 148229 [Android] Right time is picked and rounded to nearest time increment in clock mode 
 * 148241 [Android] won't open if `MinuteIncrement` is not set
 * 148582 Time picker initial time when using time increment is using initial time seconds when rounding.. it should ignore seconds.. 
 * 148285 [iOS] TimePicker is clipped off screen when ios:FlyoutPlacement isnt set

## Release 1.40

This release is the first non-experimental release of the Uno Platform since the initial public version in May 2018. Lot of bug fixes and features have been added since then, and lots more are coming.

A lot of those changes where included to support these libraries : [MVVMLight](https://github.com/nventive/uno.mvvmlight), [ReactiveUI](https://github.com/nventive/Uno.ReactiveUI), [Prism](https://github.com/nventive/Uno.Prism), [Rx.NET](https://github.com/nventive/Uno.Rx.NET), [Windows Community Toolkit](https://github.com/nventive/Uno.WindowsCommunityToolkit), [Xamarin.Forms UWP](https://github.com/nventive/Uno.Xamarin.Forms).

Here are some highlights of this release:

- General improvement in the memory consumption of the `ListView` control
- Many Wasm rendering and support updates
    - Invalid images support
    - Text and images measuring fixes
    - Add support for AppManifest.displayName
- Support for the `Pivot` control
- Support for inline XAML event handlers in `DataTemplate`
- Support for implicit styles in the `XamlReader`
- Support for `ThreadPoolTimer`
- Add support for implicit `bool` to `Visibility` conversion
- Support for `AutoSuggestBox`
- SourceLink, Reference Assemblies and deterministic builds are enabled
- Support for `x:Name` reference in `x:Bind` markup
- Support for `WriteableBitmap` for all platforms
- Added support for `Cross-platform Library` template in vsix
- Added support for `StaticResource` as top level `ResourceDictionary` element
- Added support for `AutomationPeer`
- Android status bar height is now included in `Window.Bounds`
- Add support for `Underline` in `HyperLinkButton`
- Add support for TextBlock.TextDecorations 
- TextBlock base class is now `FrameworkElement` on iOS, instead of `UILabel`
- Auto generated list of views implemented in Uno in the documentation
- Add support for string to `Type` conversion in XAML generator and binding engine
- Support for Attached Properties localization
- Added `ItemsControl.OnItemsChanged` support
- Added support for ListView GroupStyle.HeaderTemplateSelector for iOS/Android

Here's the full change log:

- Fixes for VisualTransition.Storyboard lazy bindings [#12](https://github.com/nventive/Uno/pull/12)
- ListView fixes [#22](https://github.com/nventive/Uno/pull/22)
    - Improve Path parser compatibility
    - Update assets generation documentation
    - Fix ItemsWrapGrid layout when ItemHeight/ItemWidth are not set
    - Adjust for invalid AnchorPoint support for iOS (#16)
    - Fix for ListView initialization order issue
- Default styles clearing fixes [#23](https://github.com/nventive/Uno/pull/23)
- Compatibility and stability fixes [#37](https://github.com/nventive/Uno/pull/37)
    - Wasm SplitView fixes
    - Enum fast converters
    - TextBox InputScope fixes
    - Improved ListViewBase stability
    - SimpleOrientationSensor fixes
    - PathMarkupParser: Add support for whitespace following FillRule command 
    - Fix DependencyObjectStore.PopCurrentlySettingProperty
    - Raised navigation completed after setting CanGoBack/Forward
    - Fix layouting that sometimes misapplies margin
    - Selector: Coerce SelectedItem to ensure its value is always valid 
    - Remove legacy panel default constructor restriction 
    - Wasm image support improvements
    - Add support for forward slash in image source 
    - Add support for CollectionViewSource set directly on ItemsControl.ItemSource
    - Fix Pane template binding for SplitView 
    - Add support for Object as DependencyProperty owner 
    - Add Wasm support for UIElement.Tapped 
    - Fix iOS UnregisterDoubleTapped stack overflow
- Compatibility and stability fixes [#43](https://github.com/nventive/Uno/pull/43)
    - Adjust WASM thickness support for children arrange 
    - Fix support for inline text content using ContentProperty
    - Fix memory leaks in ScrollViewer
    - Adjust for missing styles in UWP Styles FeatureConfiguration
    - Fix for Source Generation race condition on slow build servers
- Compatibility and stability fixes [#53](https://github.com/nventive/Uno/pull/53)
    - Adjust for WASM Support for local images [#1](https://github.com/nventive/Uno/issues/1)
    - Fixes x:Bind support for Wasm
    - Fix invalid deserialization of ApplicationDataContainer for iOS
    - Fix error for ApplicationView.Title for WASM
    - Remove glib conversion errors in WASM
- UWP API Alignments for Wasm [#70](https://github.com/nventive/Uno/pull/70)
    - Add support for Application.Start() to provide a proper SynchronizationContext for error management
    - Fix for ImplicitStyles support in XamlReader
    - Add support for the Pivot control using the default UWP Xaml style
    - Adjust body background color after the splash screen removal
    - Adjust the materialization of Control templates to not be lazy
- Add support for Xaml file defined event handlers [#71](https://github.com/nventive/Uno/pull/71)
- API Compatibility Updates [#75](https://github.com/nventive/Uno/pull/75)
    - Add support for implicit bool to Visibility conversion
    - Fix default Style constructor does not set the proper property precedence
    - Add more DependencyObjectStore logging
    - Align ItemsControl.Items behavior with UWP (#34)
    - Fix invalid uri parsing when set through BitmapImage.UriSource
- [WASM] Fix text measure when not connected to DOM [#76](https://github.com/nventive/Uno/pull/76)
- Pivot, AutoSuggestBox, TextBox, XamlReader updates [#77](https://github.com/nventive/Uno/pull/77)
    - Added missing TransformGroup ContentProperty
    - Fixed invalid namespace attribution of attached properties in XamlReader
    - Fixed BitmapImage.UriSource updates not being applied on Wasm
    - Add basic implementation of AutoSuggestBox
    - Fixed focus stealing issues with inactive PivotItem content
    - Add ThreadPoolTimer support
    - Fix for iOS popup not appearing
    - Fix for Wasm textbox not properly updating while not loaded
- [WASM] Add suport for TextBlock.Padding property [#88](https://github.com/nventive/Uno/pull/88)
- [WASM] Fixed measuring support with Polyfill for Node.isConnected [#89](https://github.com/nventive/Uno/pull/88), [#91](https://github.com/nventive/Uno/pull/91)
- Misc fixes [#93](https://github.com/nventive/Uno/pull/93)
    - Fixed iOS `SimpleOrientationSensor` default queue management
    - Fixed multiple memory leaks in `ListView`, `ScrollViewer`
    - Implemented `CacheLength` for Android `ListViewBase`
    - Fixed for `DependencyObject` properties inheritance race condition
    - Fix for empty Path reporting an infinite size
    - Fix Title  not appearing in CommandBar
- Add support for WebAssembly AppManifest.displayName [#94](https://github.com/nventive/Uno/pull/94)
- Enable SourceLink, Reference Assemblies, Deterministic build [#100](https://github.com/nventive/Uno/pull/100)
- Binding Engine Alignments [#113](https://github.com/nventive/Uno/pull/113)
    - Use Portable symbols for Xamarin debugging stability
    - Enable x:Name reference in x:Bind markup. This requires for a failed BindableMetadata lookup to fall through reflection lookup.
    - Assume ".Value" binding path on a primitive is equivalent to self, to enable nullable bindings.
    - Adjust unit tests logging
    - Enables auto "LogicalChild" treatment to allow for DependencyObjectCollection members to be databound
    - Enable parent reset for "LogicalChild" assignations
- Implement the CoreWindow.Dispatcher property [#117](https://github.com/nventive/Uno/pull/117)
- Misc Fixes [#120](https://github.com/nventive/Uno/pull/120)
    - Fix for CommandBar back button icon
    - Improve HyperLinks hit-testing for iOS
    - Fixed android PaintDrawable opacity
    - Adjust Unloaded event for ToggleButton
    - Adjust for brightness support
    - Adjust touch support for rotated elements
    - Adjust MinWidth/MinHeight support in Grid
    - Adjust PasswordBox custom font for during password reveal
    - ListView, ContentControl memory improvements
    - Style behavior adjustements
- Update for android animation reliability [#123](https://github.com/nventive/Uno/pull/123)
- Add support for WriteableBitmap [#125](https://github.com/nventive/Uno/pull/125)
- Updated vsix structure [#128](https://github.com/nventive/Uno/pull/128)
- Multiple enhancements for WCT 4.0 [#131](https://github.com/nventive/Uno/pull/131)
    - Adds support for `IconElement` fast conversion
    - Adds stubs for `ToggleSwitchTemplateSettings`, `PackageId`, `UISettings`
    - Adjust `XamlObjectBuilder` logging
    - Add implicit conversion for `KeyTime` and `Duration`
    - Add support for top level `StaticResource` resource dictionary elements
    - Implement FindFirstParent for net46/netstd2.0
    - Adds ElementNotAvailableException and ElementNotEnabledException
    - Fix invalid measure for empty wasm images
    - Add size/rect checks for measure/arrange wasm
    - Improve XamlReader error reporting
- Add support for Cross-platform library template in VSIX [#132](https://github.com/nventive/Uno/pull/132)
- Add support for AutomationPeer [#141](https://github.com/nventive/Uno/pull/141)
- Improved support for UWP resources [#149](https://github.com/nventive/Uno/pull/149)
    - Projects no longer need to define `XamlCodeGenerationFiles` (fixes #144)
    - Projects no longer need to define `ResourcesDirectory` (fixes #106)
    - Projects no longer need to initialize `ResourceHelper.ResourcesService` (fixes #142)
    - `ResourceLoader.GetString` is now supported (fixes #142)
- Updates rollup [#151](https://github.com/nventive/Uno/pull/151)
    - Fixed `VisualState` not updated when `TextBox` is focused
    - Improve `ListView` and `Selector` memory footprint
    - Adjust GenericStyles application sequence for Android
    - Add diagnostics methods for `BinderReferenceHolder`
    - Include android status bar height in `Window.Bounds`
    - Fixed `Grid` items size when `MinHeight` and `MinHeight` are used
    - Fixed android race condition during visual tree cleanup
    - Add support for underline in `HyperLinkButton`
    - Fixed `ScrollContentPresenter` margin issue
    - Adjust `MessageDialog` behavior for android
    - `ContentControl` Data Context is now properly unset
    - Add `EmailNameOrAddress` InputScope for `TextBox`
    - Fixed duplicated resw entry support 
    - Fixed `ComboBox` popup touch issue
    - Add support for TextBlock.TextDecorations 
    - TextBlock base class from UILabel to FrameworkElement
- Auto-generate list of views implemented in Uno [#152](https://github.com/nventive/Uno/pull/152)
- Add support for string to `Type` conversion in Xaml generator and Binding engine. [#159](https://github.com/nventive/Uno/pull/159)
- Add support for attached properties localization [#156](https://github.com/nventive/Uno/pull/156)
- Added `ItemsControl.OnItemsChanged` support [#175](https://github.com/nventive/Uno/pull/175)
- Added support for XAML inline collections declaration [#184](https://github.com/nventive/Uno/pull/184)
- Adjust the sequence of control template materialization [#192](https://github.com/nventive/Uno/pull/192)
- Support for ListView.ScrollIntoView with leading alignment
- Added support for ListView GroupStyle.HeaderTemplateSelector 
- [IOS-ANDROID] Added support for time picker minute increment 

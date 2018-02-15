# XFPrismSample
## Xamarin.FormsとPrismを使ったサンプルプロジェクト
### ポイント
- XAML
    - レイアウト - Grid, StackLayout
    - コントロール - ListView, Button
    - バインディング - Binding
    - スタイル定義 - AppTheme
- Prism
    - Prism Template Pack - ツール→拡張機能と更新プログラム→オンライン→"Prism"で検索
    - ViewとViewModel紐づける（ViewModelLocator） - AutowireViewModel=true
    - 画面遷移 - NavigationService.NavigateAsync
    - Dependency Injection（Unity） - RegisterTypes(App.xaml.cs)
- ReactiveProperty
    - プロパティ - ReactiveProperty
    - コマンド - ReactiveCommand
        - DetailPageへ移動する
        - リストが選択状態になったら実行可能にする
    - コレクション - ReadOnlyObservableCollection
    - 注意点
        - XAMLでのValueつけ忘れ
        - ReSharperプラグイン - http://blog.okazuki.jp/entry/2017/02/04/214726
- .NET Standard 2.0
    - https://blogs.msdn.microsoft.com/dotnet/2016/09/26/introducing-net-standard/
---
### TODO
- UnitTest
- AAD
- カメラサンプル

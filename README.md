# XFPrismSample
## Xamarin.FormsとPrismを使ったサンプル
- XAML
    - レイアウト - Grid, StackLayout
    - バインディング - Binding
    - スタイル定義 - AppTheme
- Prism
    - Prism Template Pack - ツール→拡張機能と更新プログラム→オンライン→"Prism"で検索
    - ViewとViewModel紐づける（ViewModelLocator） - AutowireViewModel=true
    - 画面遷移 - NavigationService.NavigateAsync
    - Dependency Injection（Unity） - RegisterTypes(App.xaml.cs)
- ReactiveProperty
    - ReactiveProperty - プロパティ
    - ReactiveCommand - コマンド
        - DetailPageへ移動する
        - リストが選択状態になったら実行可能にする
    - ReadOnlyObservableCollection - コレクション
    - 注意点 - XAMLでのValueつけ忘れ

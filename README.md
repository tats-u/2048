# 2048 for Visual C#

[4×4のマス目に出現する数字のタイルを集めて2048を作るおなじみのゲーム](https://gabrielecirulli.github.io/2048/) を見よう見まねで作ったものです。
作ったのは恐らく2014年頃です。

<img src="https://user-images.githubusercontent.com/12870451/62098561-d1393700-b2c5-11e9-833e-d4674e352263.png" alt="タイトル" width="389"><img src="https://user-images.githubusercontent.com/12870451/62098569-db5b3580-b2c5-11e9-999a-e8e42796ced0.png" alt="クリア直前" width="389">
<img src="https://user-images.githubusercontent.com/12870451/62098563-d4ccbe00-b2c5-11e9-9a41-183d4595c559.png" alt="クリア" width="389"><img src="https://user-images.githubusercontent.com/12870451/62098566-d8604500-b2c5-11e9-9a13-b81348d29a43.png" alt="ゲームオーバー" width="389">

作成当時は.NET Framework 4.5向けでしたが、現在は.NET Core向けに改修済みです。

## ダウンロード

[Releases](https://github.com/tats-u/2048/releases) からバイナリがダウンロード可能です。

## ビルド方法

予め.NET Core 3以上のSDKをインストールしてください。

### Visual Studio

`2048 on PC.sln`を開き、ビルドしてください。

### コマンドライン

### .NET Core CLI (dotnetコマンド)

`dotnet`コマンドにパスが通っている端末から以下のコマンドを実行してください。

```cmd
dotnet build
```

#### MSBuild

x64 Native Tools Command Promptなど、MSBuildを実行できる端末から以下のコマンドを実行してください。

```cmd
MSBuild . -p:Configuration=Release -p:Platform="Any CPU" -m
```

バイナリの場所は`2048 on PC\bin\Release\netcoreapp3.0` (または`Debug\netcoreapp3.0`)です。

# U'sTEC ProgrammingTraining

ユーズテックのプログラミング課題サンプルリポジトリ
![demo](https://user-images.githubusercontent.com/43688962/83635534-5aed1b80-a5df-11ea-8510-89277fe5e6d2.gif)

## アプリケーションについて
- 一つのSolutionの中に2つのPRISM Applicationが存在している。
- スタートアッププロジェクトを切り替えることでそれぞれのアプリケーションのデバック実行が可能。
  - Rx版：ProgrammingTraining
  - Normal版：ProgrammingTraining.BasicWpfApp


## 環境
- .Net Core 3.1
- C# 7.x
- PRISM 7.2.x

## 検査一覧プログラムの要求仕様

- 検査依頼データ取り込みプログラムにより取り込まれた検査依頼データの一覧を表示できること
- 検査日付で表示対象検査を絞り込めること。患者 ID で表示対象検査を絞り込めること。両方入力された場合は AND 検索となること etc.

## Commit ガイドライン

### 例 1

- fix：バグ修正
- add：新規（ファイル）機能追加
- update：機能修正（バグではない）
- remove：削除（ファイル）

### 例 2

- fix：バグ修正
- hotfix：クリティカルなバグ修正
- add：新規（ファイル）機能追加
- update：機能修正（バグではない）
- change：仕様変更
- clean：整理（リファクタリング等）
- disable：無効化（コメントアウト等）
- remove：削除（ファイル）
- upgrade：バージョンアップ
- revert：変更取り消し

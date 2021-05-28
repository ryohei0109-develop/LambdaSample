# LambdaSample
##概要
AWS Lambdaを実行できるc#のサンプルプログラムです。
Lambda実行時に呼ばれるのはLambdaSample.Function()になります。

##使用準備

###AWS CLI
あらかじめAWS CLIをインストールし、プロファイルを設定する必要があります。

###
「aws-lambda-tools-defaults.json」
Lambdaの各種設定ファイルになります。
お使いの環境に合わせて編集して下さい。

###デプロイスクリプトファイル
「lambda-deploy.command」
Lambdaへデプロイするためのスクリプトファイルになります。
本プロジェクトの名称を変更した場合は、スクリプト内を書き換える必要があります。
GUIでダブルクリックして実行するだけでデプロイすることも可能です。

// グローバルに展開
phina.globalize();
// アセット
var ASSETS = {
    // 画像
    image: {
        'bg': 'http://www.mediafire.com/convkey/e34c/jdcpjzrmzfdhgkdzg.jpg',
        'player': 'http://www.mediafire.com/convkey/a4a7/ci395375s6k44kxzg.jpg',
        'arrow': 'http://www.mediafire.com/convkey/662d/gmh23aw037jwkbkzg.jpg',
        'hukidashi': 'http://www.mediafire.com/convkey/9bef/5i6yvn4yy8qbj3kzg.jpg',
        'stagehaikei1': 'http://www.mediafire.com/convkey/d572/nxvoritxbo4nnfgzg.jpg',
        'stagehaikei2': 'http://www.mediafire.com/convkey/8a60/s65h6bx5okm2aq4zg.jpg',
        'stage_umi1': 'http://www.mediafire.com/convkey/c827/36c28x5uzw3bob4zg.jpg',
        'stage_umi2': 'http://www.mediafire.com/convkey/fcc3/u9s6bztgrubrp97zg.jpg',
        'stage_umi3': 'http://www.mediafire.com/convkey/5c6f/u288f3y8cf5i3t1zg.jpg',
    },

    sound: {
        'test': 'http://download2269.mediafire.com/yzzbjsaqu3ag/751b1s4ibaiesl6/bgm_maoudamashii_8bit13.mp3',
        'gameover': 'http://download2261.mediafire.com/9p63okqfrd6g/pbk9set5xp42wp7/8bit-ME_Victory01.mp3',
    },

};
// 定数
var SCREEN_WIDTH = 640;               //画面の横幅
var SCREEN_HEIGHT = 960;              //画面の縦幅
var PLAYER_SPEED = 20;                //落下スピード
var STAGE_SPEED_A = 4;                 //背景の動くスピード
var STAGE_FLAG1 = 1;                   //背景のフラグ
var STAGE_FLAG2 = 0;                   //背景のフラグ２
var STAGE_SPEED_B = 1;                 //海の動きの速さ
var STAGE_FLAG3 = 1;                   //背景２のフラグ１
var STAGE_FLAG4 = 0;                   //背景２のフラグ２
var umi_1 = 20;                           //海のアニメーションスコア
var umi_FLAG1 = 0;                      //海のアニメーションフラグ
var umi_2 = 10;                           //海のアニメーションスコア
var umi_FLAG2 = 0;                      //海のアニメーションフラグ
var umi_3 = 5;                           //海のアニメーションスコア
var umi_FLAG3 = 0;                      //海のアニメーションフラグ
var FLAG = 0;                          //落下のフラグ
var GROUND_FLAG = 0;                   //地面が動き出すフラグ
var GROUND_Count = 50;                //地面が動き出すまでの時間
var shapeC, shapeG, scoreN, rectangle;   //各ジャンプの図形
var FLYING_GAUGE = 100;                //ゲージの初期数値
var gauge;                            //ゲージの宣言
var score = 0;                         //スコアの初期
var scores = 0;                        //スコアを増やすための変数
var result = 0;                           //ハイスコア
var scoreLabel;                       //スコアの宣言
var Debak;                            //FLAGを表示
var i = 1, j = 10;                         //制御変数
var GROUND_WIDTH = 200;               //陸の横幅
var GROUND_HEIGHT = 200;              //陸の立幅
var g = 0;


/*
 * タイトル
 */
phina.define("TitleScene", {
    // 継承
    superClass: 'DisplayScene',
    // 初期化
    init: function () {
        // 親クラス初期化
        this.superInit();
        // 背景色
        this.backgroundColor = 'blue';
        // ラベル
        Label({
            text: '水切りペンギン',
            fontSize: 48,
            fill: 'yellow',
        }).addChildTo(this).setPosition(this.gridX.center(), this.gridY.span(5));

        // ラベル
        TOUCH = Label({
            text: 'TOUCH TO START',
            fontSize: 40,
            fill: 'yellow',
        }).addChildTo(this).setPosition(this.gridX.center(), this.gridY.span(12));
        TOUCH.alpha = 1;

    },

    update: function () {
        //テキスト点滅
        scores++;
        if (scores === 3) {
            if (i === 1) {
                TOUCH.alpha = TOUCH.alpha - 0.1;
                j--;
                if (j === 0) {
                    i--;
                }
            } else if (i === 0) {
                TOUCH.alpha = TOUCH.alpha + 0.1;
                j++;
                if (j === 10) {
                    i++;
                }
            }
            scores = 0;
        }
    },

    // タッチで次のシーンへ
    onpointstart: function () {
        this.exit();
    },



});

/*
 * メインシーン
 */
phina.define("MainScene", {
    // 継承
    superClass: 'DisplayScene',
    // コンストラクタ
    init: function () {
        // 親クラス初期化
        this.superInit();

        //スコア初期化
        score = 0;
        scores = 0;

        //ゲージ初期化
        FLYING_GAUGE = 100;

        //グラウンド初期化
        GROUND_Count = 30;

        //フラグ初期化
        STAGE_FLAG2 = 0;
        STAGE_FLAG4 = 0;

        //海の初期化
        umi_1 = 10;
        umi_2 = 15;
        umi_3 = 20;
        umi_FLAG1 = 0;
        umi_FLAG2 = 0;
        umi_FLAG3 = 0;


        //音再生
        SoundManager.playMusic('test');


        // 背景
        this.backgroundColor = 'Skyblue';
        stagehaikei1 = Sprite('stagehaikei1').addChildTo(this)
            .setPosition(this.gridX.span(23), this.gridY.span(3));

        stagehaikei2 = Sprite('stagehaikei1').addChildTo(this)
            .setPosition(this.gridX.span(23), this.gridY.span(3));
        stagehaikei2.x = 1600;

        stagehaikei3 = Sprite('stagehaikei2').addChildTo(this)
            .setPosition(this.gridX.span(23), this.gridY.span(7.5));

        stagehaikei4 = Sprite('stagehaikei2').addChildTo(this)
            .setPosition(this.gridX.span(23), this.gridY.span(7.5));
        stagehaikei4.x = 1600;

        //海
        umi1 = Sprite('stage_umi1').addChildTo(this)
            .setPosition(this.gridX.center(), this.gridY.span(12));

        umi2 = Sprite('stage_umi2').addChildTo(this)
            .setPosition(this.gridX.center(), this.gridY.span(14));

        umi3 = Sprite('stage_umi3').addChildTo(this)
            .setPosition(this.gridX.center(), this.gridY.span(16));



        // 判定対象C
        shapeC = Shape({
            backgroundColor: 'blue',//画像の色
            x: this.gridX.center(),　//ｘ座標
            y: this.gridY.span(11),  //y座標
            width: 20,             //幅
            height: 20,            //高さ
        }).addChildTo(this);

        // 判定対象G
        shapeG = Shape({
            backgroundColor: 'blue',//画像の色
            x: this.gridX.center(),　//ｘ座標
            y: this.gridY.span(12),  //y座標
            width: 20,             //幅
            height: 20,            //高さ
        }).addChildTo(this);

        // 判定対象N
        shapeN = Shape({
            backgroundColor: 'blue',//画像の色
            x: this.gridX.center(),　//ｘ座標
            y: this.gridY.span(13),  //y座標
            width: 20,             //幅
            height: 20,            //高さ
        }).addChildTo(this);



        //ground
        ground = Shape({
            backgroundColor: 'blue',//画像の色
            x: this.gridX.span(-13),　//ｘ座標
            y: this.gridY.span(8),  //y座標
            width: GROUND_WIDTH,             //幅
            height: GROUND_HEIGHT,            //高さ
        }).addChildTo(this);

        // ゲージ
        gauge = Gauge({
            x: 500,  //x座標               
            y: 60,   //y座標     
            width: 250,            // 横サイズ
            height: 30,            // 縦サイズ
            cornerRadius: 10,      // 角丸み
            maxValue: 100,         // ゲージ最大値
            value: FLYING_GAUGE,         // ゲージ初期値
            fill: 'white',         // 後ろの色
            gaugeColor: 'Green', // ゲージ色
            stroke: 'silver',      // 枠色
            strokeWidth: 5,        // 枠太さ
        }).addChildTo(this);

        //スコア
        scoreLabel = Label({
            text: score + '' + 'm',//スコアテキスト
            fill: 'white',//テキストの色
            fontSize: 50,//フォントサイズ

        }).addChildTo(this);
        scoreLabel.setPosition(this.gridX.span(4), this.gridY.span(1));
        scoreLabel.alpha = 0.6;

        //Debak
        Debak = Label({
            text: FLAG + '',
            fill: 'white',
            fontSize: 50,

        }).addChildTo(this);
        Debak.setPosition(this.gridX.span(8), this.gridY.span(1));
        Debak.alpha = 0.6;


        // プレイヤー
        this.player = Player().addChildTo(this);
        this.player.setPosition(this.gridX.center(), this.gridY.span(5));
        this.player.scaleX += 0.5;
        this.player.scaleY += 0.5;






        // 画面タッチを有効にする
        this.setInteractive(true);

    },
    update: function () {
        // 矩形判定C
        if (this.player.hitTestElement(shapeC)) {
            shapeC.backgroundColor = 'red';
        }
        else {
            shapeC.backgroundColor = 'blue';
        }

        //背景FLAG処理
        if (stagehaikei1.x === -320) {
            STAGE_FLAG2 = 1;
            stagehaikei2.x = 1600;
        }

        if (stagehaikei2.x === -320) {
            STAGE_FLAG1 = 1;
            stagehaikei1.x = 1600;
        }


        //背景移動
        if (STAGE_FLAG1 === 1) {
            stagehaikei1.x -= STAGE_SPEED_A;
        }
        if (STAGE_FLAG2 === 1) {
            stagehaikei2.x -= STAGE_SPEED_A;
        }

        //背景FLAG処理2
        if (stagehaikei3.x === -320) {
            STAGE_FLAG4 = 1;
            stagehaikei4.x = 1600;
        }

        if (stagehaikei4.x === -320) {
            STAGE_FLAG3 = 1;
            stagehaikei3.x = 1600;
        }


        //背景移動2
        if (STAGE_FLAG3 === 1) {
            stagehaikei3.x -= PLAYER_SPEED;
        }
        if (STAGE_FLAG4 === 1) {
            stagehaikei4.x -= PLAYER_SPEED;
        }

        /*
        //海アニメーション
        */
        //1
        if (score === umi_1) {
            if (umi_FLAG1 === 0) {
                umi_FLAG1 = 1;
            } else if (umi_FLAG1 === 1) {
                umi_FLAG1 = 0;
            }
            umi_1 += 10;
        }

        if (umi_FLAG1 === 0) {
            umi1.y -= STAGE_SPEED_B;
        } else if (umi_FLAG1 === 1) {
            umi1.y += STAGE_SPEED_B;
        }

        //2
        if (score === umi_2) {
            if (umi_FLAG2 === 0) {
                umi_FLAG2 = 1;
            } else if (umi_FLAG2 === 1) {
                umi_FLAG2 = 0;
            }
            umi_2 += 15;
        }

        if (umi_FLAG2 === 0) {
            umi2.y -= STAGE_SPEED_B;
        } else if (umi_FLAG2 === 1) {
            umi2.y += STAGE_SPEED_B;
        }


        //3
        if (score === umi_3) {
            if (umi_FLAG3 === 0) {
                umi_FLAG3 = 1;
            } else if (umi_FLAG3 === 1) {
                umi_FLAG3 = 0;
            }
            umi_3 += 20;
        }
        if (umi_FLAG3 === 0) {
            umi3.y -= STAGE_SPEED_B;
        } else if (umi_FLAG3 === 1) {
            umi3.y += STAGE_SPEED_B;
        }



        //プレイヤーの挙動
        if (FLAG === 0) {
            this.player.y += PLAYER_SPEED;
            this.player.rotation++;
        } else if (FLAG === 1) {
            this.player.y -= PLAYER_SPEED;
            this.player.rotation--;
        } else if (FLAG === 2) {
            this.player.y -= PLAYER_SPEED;
            this.player.rotation--;

        }

        //FLAGが２だった場合はFLAING_GAUGEをへらす
        if (FLAG === 2) {
            FLYING_GAUGE--;
            gauge.value = FLYING_GAUGE;
        }

        //FLAGが１だった場合に判定をどかす
        if (FLAG === 1) {
            shapeG.x = 0;
            shapeN.x = 0;
            shapeC.x = 0;
        } else {
            shapeG.x = 320;
            shapeN.x = 320;
            shapeC.x = 320;
        }


        // 矩形判定G
        if (this.player.hitTestElement(shapeG)) {
            shapeG.backgroundColor = 'red';
        }
        else {
            shapeG.backgroundColor = 'blue';
        }

        // 矩形判定N
        if (this.player.hitTestElement(shapeN)) {
            shapeN.backgroundColor = 'red';
        }
        else {
            shapeN.backgroundColor = 'blue';
        }




        //ランキング画面への移行処理
        if (this.player.hitTestElement(ground)) {

            ground.backgroundColor = 'red';
            this.exit();
            //音の停止
            //SoundManager.stopMusic('test');
        }
        else {
            ground.backgroundColor = 'blue';
        }

        //グラウンドを動かす処理
        if (score === GROUND_Count) {
            ground.x = 650;
            GROUND_FLAG = 1;
            GROUND_Count += 30;
        }

        if (GROUND_FLAG === 1) {
            ground.x -= PLAYER_SPEED;
        }



        //画面上部の上限
        if (this.player.y < 0) {
            this.player.y = 0;
            FLAG = 0;
        }

        //画面下部の上限
        if (this.player.y > SCREEN_HEIGHT) {
            //次のシーンへ
            this.exit();
            //音の停止
            SoundManager.stopMusic('test');
        }
        //スコア加算
        scores++;
        if (scores === 5) {
            score += scores / 5;
            scoreLabel.text = score + 'm';
            scores = 0;
        }

        //Debak
        Debak.text = umi_FLAG1;


        //FLYING_GAUGEが変わっているかどうかの判定
        if (gauge.value > 80 && gauge.value < 100) {
            gauge.gaugeColor = 'Green';
        }
        else if (gauge.value > 50 && gauge.value < 80) {
            gauge.gaugeColor = 'Yellow';
        } else if (gauge.value > 20 && gauge.value < 50) {
            gauge.gaugeColor = 'orange';
        } else if (gauge.value > 0 && gauge.value < 20) {
            gauge.gaugeColor = 'red';
        }




    },


    //タップした時の判定
    onpointstart: function (e) {
        // 矩形判定C
        if (this.player.hitTestElement(shapeC)) {
            FLAG = 1;
            FLYING_GAUGE += 1;
            gauge.value = FLYING_GAUGE;
            if (FLYING_GAUGE >= 100) {
                FLYING_GAUGE = 100;
            }

        }

        // 矩形判定G
        if (this.player.hitTestElement(shapeG)) {
            FLAG = 1;
            FLYING_GAUGE += 10;
            gauge.value = FLYING_GAUGE;
            if (FLYING_GAUGE >= 100) {
                FLYING_GAUGE = 100;
            }


        }

        // 矩形判定N
        if (this.player.hitTestElement(shapeN)) {
            FLAG = 1;
            FLYING_GAUGE += 1;
            gauge.value = FLYING_GAUGE;
            if (FLYING_GAUGE >= 100) {
                FLYING_GAUGE = 100;
            }
        }

    },

    //タッチしている間の判定
    onpointstay: function (e) {

        //短形判定C
        if (this.player.hitTestElement(shapeC)) {
            //FLYING_GAUGE = FLYING_GAUGE;
        } else if (FLYING_GAUGE > 0 && FLAG === 0) {
            FLAG = 2;
            FLYING_GAUGE--;
            gauge.value = FLYING_GAUGE;
        }

        //短形判定G
        if (this.player.hitTestElement(shapeG)) {
            // FLYING_GAUGE = FLYING_GAUGE;
        } else if (FLYING_GAUGE > 0 && FLAG === 0) {
            FLAG = 2;
            FLYING_GAUGE--;
            gauge.value = FLYING_GAUGE;
        }

        //短形判定N
        if (this.player.hitTestElement(shapeN)) {
            //FLYING_GAUGE = FLYING_GAUGE;
        } else if (FLYING_GAUGE > 0 && FLAG === 0) {
            FLAG = 2;
            FLYING_GAUGE--;
            gauge.value = FLYING_GAUGE;
        }

        if (FLAG === 0) {
            FLYING_GAUGE--;
            gauge.value = FLYING_GAUGE;
        }
    },

    onpointend: function (e) {
        if (FLAG === 2) {
            FLAG = 0;
        }
    }
});
/*
 * プレイヤークラス
 */
phina.define("Player", {
    // 継承
    superClass: 'Sprite',
    // コンストラクタ
    init: function () {
        // 親クラス初期化
        this.superInit('player');
    },
});

/*
 * ランキング
 */
phina.define("Ranking", {
    // 継承
    superClass: 'DisplayScene',
    // 初期化
    init: function () {
        // 親クラス初期化
        this.superInit();

        //音再生
        SoundManager.play('gameover');

        //ハイスコア表示
        if (score >= result) {
            result = score;
        } else {
            Best.hide();
        }

        // 背景色
        this.backgroundColor = 'DeepSkyblue';

        // 吹き出し
        hukidashi = Sprite('hukidashi').addChildTo(this)
            .setPosition(this.gridX.span(8.25), this.gridY.span(3.5));
        hukidashi.scaleX += 13;
        hukidashi.scaleY += 13;

        // 吹き出し2
        hukidashi = Sprite('hukidashi').addChildTo(this)
            .setPosition(this.gridX.span(8.25), this.gridY.span(11));
        hukidashi.scaleX += 13;
        hukidashi.scaleY += 13;

        //pengin
        pengin = Sprite('player').addChildTo(this)
            .setPosition(this.gridX.span(2), this.gridY.span(7));
        pengin.scaleX += 2;
        pengin.scaleY += 2;
        // ラベル
        Label({
            text: score + '' + "m",
            fontSize: 62,
            fill: 'black',
        }).addChildTo(this).setPosition(this.gridX.center(), this.gridY.span(5));

        // ラベル2
        Label({
            text: "今回の結果",
            fontSize: 50,
            fill: 'black',
        }).addChildTo(this).setPosition(this.gridX.center(), this.gridY.span(2));

        // ラベル3
        Label({
            text: "ベストスコア",
            fontSize: 50,
            fill: 'black',
        }).addChildTo(this).setPosition(this.gridX.center(), this.gridY.span(9));

        // ラベル4
        Label({
            text: result + '' + "m",
            fontSize: 62,
            fill: 'black',
        }).addChildTo(this).setPosition(this.gridX.center(), this.gridY.span(12));

        // ラベル5
        Best = Label({
            text: "記録更新！",
            fontSize: 50,
            fill: 'red',
        }).addChildTo(this).setPosition(this.gridX.center(), this.gridY.span(3.5));
        Best.alpha = 0;
    },

    update: function () {

        //テキスト点滅
        scores++;
        if (scores === 3) {
            if (i === 1) {
                Best.alpha = Best.alpha + 0.1;
                pengin.rotation += 10;
                j--;
                if (j === 0) {
                    i--;
                }
            } else if (i === 0) {
                Best.alpha = Best.alpha - 0.1;
                pengin.rotation -= 10;
                j++;
                if (j === 10) {
                    i++;
                }
            }
            scores = 0;
        }
    },

    // タッチで次のシーンへ
    onpointstart: function () {
        this.exit();
    },
});




/*
 * メイン処理
 */
phina.main(function () {

    // アプリケーションを生成
    var app = GameApp({
        // アセット読み込み
        assets: ASSETS,
        // メインシーンから開始
        startLabel: 'TitleScene',
        scenes: [
            {
                className: 'TitleScene',
                label: 'TitleScene',
                nextLabel: 'MainScene'
            },

            {
                className: 'MainScene',
                label: 'MainScene',
                nextLabel: 'Ranking',
            },

            {
                className: 'Ranking',
                label: 'Ranking',
                nextLabel: 'TitleScene',
            },
        ]


    });
    // 実行
    app.run();
});
using System;

namespace GanaKana
{
    public static class Data
    {
        // Element Count
        public const int normDictCount = 80;
        public const int normDictHeight = 16;
        public const int normDictWidth = 5;
        public const int combDictCount = 33;
        public const int combDictHeight = 11;
        public const int combDictWidth = 3;

        // Size: 16 * 5
        public static readonly (string, string)[] hiraganaDict =
        {
            ( "あ", "a" ), ( "い", "i" ), ( "う", "u" ), ( "え", "e" ), ( "お", "o" ),
            ( "か", "ka" ), ( "き", "ki" ), ( "く", "ku" ), ( "け", "ke" ), ( "こ", "ko" ),
            ( "が", "ga" ), ( "ぎ", "gi" ), ( "ぐ", "gu" ), ( "げ", "ge" ), ( "ご", "go" ),
            ( "さ", "sa" ), ( "し", "shi" ), ( "す", "su" ), ( "せ", "se" ), ( "そ", "so" ),
            ( "ざ", "za" ), ( "じ", "ji" ), ( "ず", "zu" ), ( "ぜ", "ze" ), ( "ぞ", "zo" ),
            ( "た", "ta" ), ( "ち", "chi" ), ( "つ", "tsu" ), ( "て", "te" ), ( "と","to" ),
            ( "だ", "da" ), ( "ぢ", "ji" ), ( "づ", "zu" ), ( "で", "de" ), ( "ど","do" ),
            ( "な", "na" ), ( "に", "ni" ), ( "ぬ", "nu" ), ( "ね", "ne" ), ( "の","no" ),
            ( "は", "ha" ), ( "ひ", "hi" ), ( "ふ", "fu" ), ( "へ", "he" ), ( "ほ","ho" ),
            ( "ば", "ba" ), ( "び", "bi" ), ( "ぶ", "bu" ), ( "べ", "be" ), ( "ぼ","bo" ),
            ( "ぱ", "pa" ), ( "ぴ", "pi" ), ( "ぷ", "pu" ), ( "ぺ", "pe" ), ( "ぽ","po" ),
            ( "ま", "ma" ), ( "み", "mi" ), ( "む", "mu" ), ( "め", "me" ), ( "も","mo" ),
            ( "や", "ya" ), ( "", "" ), ( "ゆ", "yu" ), ( "", "" ), ( "よ","yo" ),
            ( "ら", "ra" ), ( "り", "ri" ), ( "る", "ru" ), ( "れ", "re" ), ( "ろ","ro" ),
            ( "わ", "wa" ), ( "", "" ), ( "", "" ), ( "", "" ), ( "を","wo"  ),
            ( "ん", "n" ),  ( "", "" ), ( "", "" ), ( "", "" ), ( "", "" )
        };



        public static readonly (string, string)[] katakanaDict =
        {
            ( "ア", "a" ), ( "イ", "i" ), ( "ウ", "u" ), ( "エ", "e" ), ( "オ", "o" ),
            ( "カ", "ka" ), ( "キ", "ki" ), ( "ク", "ku" ), ( "ケ", "ke" ), ( "コ", "ko" ),
            ( "ガ", "ga" ), ( "ギ", "gi" ), ( "グ", "gu" ), ( "ゲ", "ge" ), ( "ゴ", "go" ),
            ( "サ", "sa" ), ( "シ", "shi" ), ( "ス", "su" ), ( "セ", "se" ), ( "ソ", "so" ),
            ( "ザ", "za" ), ( "ジ", "ji" ), ( "ズ", "zu" ), ( "ゼ", "ze" ), ( "ゾ", "zo" ),
            ( "タ", "ta" ), ( "チ", "chi" ), ( "ツ", "tsu" ), ( "テ", "te" ), ( "ト", "to" ),
            ( "ダ", "da" ), ( "ヂ", "ji" ), ( "ヅ", "zu" ), ( "デ", "de" ), ( "ド", "do" ),
            ( "ナ", "na" ), ( "ニ", "ni" ), ( "ヌ", "nu" ), ( "ネ", "ne" ), ( "ノ", "no" ),
            ( "ハ", "ha" ), ( "ヒ", "hi" ), ( "フ", "fu" ), ( "ヘ", "he" ), ( "ホ", "ho" ),
            ( "バ", "ba" ), ( "ビ", "bi" ), ( "ブ", "bu" ), ( "ベ", "be" ), ( "ボ", "bo" ),
            ( "パ", "pa" ), ( "ピ", "pi" ), ( "プ", "pu" ), ( "ペ", "pe" ), ( "ポ", "po" ),
            ( "マ", "ma" ), ( "ミ", "mi" ), ( "ム", "mu" ), ( "メ", "me" ), ( "モ", "mo" ),
            ( "ヤ", "ya" ), ( "", "" ), ( "ユ", "yu" ), ( "", "" ), ( "ヨ", "yo" ),
            ( "ラ", "ra" ), ( "リ", "ri" ), ( "ル", "ru" ), ( "レ", "re" ), ( "ロ", "ro" ),
            ( "ワ", "wa" ), ( "", "" ), ( "", "" ), ( "", "" ), ( "ヲ", "wo" ),
            ( "ン", "n"  ), ( "", "" ), ( "", "" ), ( "", "" ), ( "", "" ),
        };

        // Size: 11 * 3
        public static readonly (string, string)[] hiraganaCombDict =
        {
            ( "きゃ", "kya" ), ( "きゅ", "kyu" ), ( "きょ", "kyo" ),
            ( "ぎゃ", "gya" ), ( "ぎゅ", "gyu" ), ( "ぎょ", "gyo" ),
            ( "しゃ", "sha" ), ( "しゅ", "shu" ), ( "しょ", "sho" ),
            ( "じゃ", "ja" ), ( "じゅ", "ju" ), ( "じょ", "jo" ),
            ( "ちゃ", "cha" ), ( "ちゅ", "chu" ), ( "ちょ", "cho" ),
            ( "にゃ", "nya" ), ( "にゅ", "nyu" ), ( "にょ", "nyo" ),
            ( "ひゃ", "hya" ), ( "ひゅ", "hyu" ), ( "ひょ", "hyo" ),
            ( "びゃ", "bya" ), ( "びゅ", "byu" ), ( "びょ", "byo" ),
            ( "ぴゃ", "pya" ), ( "ぴゅ", "pyu" ), ( "ぴょ", "pyo" ),
            ( "みゃ", "mya" ), ( "みゅ", "myu" ), ( "みょ", "myo" ),
            ( "りゃ", "rya" ), ( "りゅ", "ryu" ), ( "りょ", "ryo" )
        };

        public static readonly (string, string)[] katakanaCombDict =
        {
            ( "キャ", "kya" ), ( "キュ", "kyu" ), ( "キョ", "kyo" ),
            ( "ギャ", "gya" ), ( "ギュ", "gyu" ), ( "ギョ", "gyo" ),
            ( "シャ", "sha" ), ( "シュ", "shu" ), ( "ショ", "sho" ),
            ( "ジャ", "ja" ), ( "ジュ", "ju" ), ( "ジョ", "jo" ),
            ( "チャ", "cha" ), ( "チュ", "chu" ), ( "チョ", "cho" ),
            ( "ニャ", "nya" ), ( "ニュ", "nyu" ), ( "ニョ", "nyo" ),
            ( "ヒャ", "hya" ), ( "ヒュ", "hyu" ), ( "ヒョ", "hyo" ),
            ( "ビャ", "bya" ), ( "ビュ", "byu" ), ( "ビョ", "byo" ),
            ( "ピャ", "pya" ), ( "ピュ", "pyu" ), ( "ピョ", "pyo" ),
            ( "ミャ", "mya" ), ( "ミュ", "myu" ), ( "ミョ", "myo" ),
            ( "リャ", "rya" ), ( "リュ", "ryu" ), ( "リョ", "ryo" )
        };

        public static (string, string) PickRandom(bool enableHiragana, bool enableKatakana, bool enableCombination)
        {
            int randMaximum = 0;
            if (enableHiragana) randMaximum += normDictCount;
            if (enableKatakana) randMaximum += normDictCount;
            if (enableHiragana && enableCombination) randMaximum += combDictCount;
            if (enableKatakana && enableCombination) randMaximum += combDictCount;

            Random rand = new Random();
            (string, string) result = ("", "");

            while (result.Item1 == "")
            {
                int randInt = rand.Next(randMaximum);

                if (enableHiragana)
                {
                    if (randInt < normDictCount)
                    {
                        result = hiraganaDict[randInt];
                        continue;
                    }
                    else
                    {
                        randInt -= normDictCount;
                    }
                }
                if (enableKatakana)
                {
                    if (randInt < normDictCount)
                    {
                        result = katakanaDict[randInt];
                        continue;
                    }
                    else
                    {
                        randInt -= normDictCount;
                    }
                }

                if (enableHiragana && enableCombination)
                {
                    if (randInt < combDictCount)
                    {
                        result = hiraganaCombDict[randInt];
                        continue;
                    }
                    else
                    {
                        randInt -= combDictCount;
                    }
                }

                result = katakanaCombDict[randInt];
                continue;

            }

            return result;
        }
    }
}

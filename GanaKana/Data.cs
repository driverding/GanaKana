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

        public enum Type { Standard, Special };

        // Size: 16 * 5
        public static readonly (string, string, Type)[] hiraganaDict =
        {
            ( "あ", "a", Type.Standard ), ( "い", "i", Type.Standard ), ( "う", "u", Type.Standard ), ( "え", "e", Type.Standard ), ( "お", "o", Type.Standard ),
            ( "か", "ka", Type.Standard ), ( "き", "ki", Type.Standard ), ( "く", "ku", Type.Standard ), ( "け", "ke", Type.Standard ), ( "こ", "ko", Type.Standard ),
            ( "が", "ga", Type.Standard ), ( "ぎ", "gi", Type.Standard ), ( "ぐ", "gu", Type.Standard ), ( "げ", "ge", Type.Standard ), ( "ご", "go", Type.Standard ),
            ( "さ", "sa", Type.Standard ), ( "し", "shi", Type.Standard ), ( "す", "su", Type.Standard ), ( "せ", "se", Type.Standard ), ( "そ", "so", Type.Standard ),
            ( "ざ", "za", Type.Standard ), ( "じ", "ji", Type.Standard ), ( "ず", "zu", Type.Standard ), ( "ぜ", "ze", Type.Standard ), ( "ぞ", "zo", Type.Standard ),
            ( "た", "ta", Type.Standard ), ( "ち", "chi", Type.Standard ), ( "つ", "tsu", Type.Standard ), ( "て", "te", Type.Standard ), ( "と","to", Type.Standard ),
            ( "だ", "da", Type.Standard ), ( "ぢ", "ji", Type.Standard ), ( "づ", "zu", Type.Standard ), ( "で", "de", Type.Standard ), ( "ど","do", Type.Standard ),
            ( "な", "na", Type.Standard ), ( "に", "ni", Type.Standard ), ( "ぬ", "nu", Type.Standard ), ( "ね", "ne", Type.Standard ), ( "の","no", Type.Standard ),
            ( "は", "ha", Type.Standard ), ( "ひ", "hi", Type.Standard ), ( "ふ", "fu", Type.Standard ), ( "へ", "he", Type.Standard ), ( "ほ","ho", Type.Standard ),
            ( "ば", "ba", Type.Standard ), ( "び", "bi", Type.Standard ), ( "ぶ", "bu", Type.Standard ), ( "べ", "be", Type.Standard ), ( "ぼ","bo", Type.Standard ),
            ( "ぱ", "pa", Type.Standard ), ( "ぴ", "pi", Type.Standard ), ( "ぷ", "pu", Type.Standard ), ( "ぺ", "pe", Type.Standard ), ( "ぽ","po", Type.Standard ),
            ( "ま", "ma", Type.Standard ), ( "み", "mi", Type.Standard ), ( "む", "mu", Type.Standard ), ( "め", "me", Type.Standard ), ( "も","mo", Type.Standard ),
            ( "や", "ya", Type.Standard ), ( "", "", Type.Standard ), ( "ゆ", "yu", Type.Standard ), ( "", "", Type.Standard ), ( "よ","yo", Type.Standard ),
            ( "ら", "ra", Type.Standard ), ( "り", "ri", Type.Standard ), ( "る", "ru", Type.Standard ), ( "れ", "re", Type.Standard ), ( "ろ","ro", Type.Standard ),
            ( "わ", "wa", Type.Standard ), ( "ゐ", "wi", Type.Special ), ( "", "", Type.Standard ), ( "ゑ", "we", Type.Special ), ( "を","wo" , Type.Standard ),
            ( "", "", Type.Standard ),  ( "", "", Type.Standard ), ( "ゔ", "vu", Type.Special ), ( "", "", Type.Standard ), ( "ん", "n", Type.Standard )
        };



        public static readonly (string, string, Type)[] katakanaDict =
        {
            ( "ア", "a", Type.Standard ), ( "イ", "i", Type.Standard ), ( "ウ", "u", Type.Standard ), ( "エ", "e", Type.Standard ), ( "オ", "o", Type.Standard ),
            ( "カ", "ka", Type.Standard ), ( "キ", "ki", Type.Standard ), ( "ク", "ku", Type.Standard ), ( "ケ", "ke", Type.Standard ), ( "コ", "ko", Type.Standard ),
            ( "ガ", "ga", Type.Standard ), ( "ギ", "gi", Type.Standard ), ( "グ", "gu", Type.Standard ), ( "ゲ", "ge", Type.Standard ), ( "ゴ", "go", Type.Standard ),
            ( "サ", "sa", Type.Standard ), ( "シ", "shi", Type.Standard ), ( "ス", "su", Type.Standard ), ( "セ", "se", Type.Standard ), ( "ソ", "so", Type.Standard ),
            ( "ザ", "za", Type.Standard ), ( "ジ", "ji", Type.Standard ), ( "ズ", "zu", Type.Standard ), ( "ゼ", "ze", Type.Standard ), ( "ゾ", "zo", Type.Standard ),
            ( "タ", "ta", Type.Standard ), ( "チ", "chi", Type.Standard ), ( "ツ", "tsu", Type.Standard ), ( "テ", "te", Type.Standard ), ( "ト", "to", Type.Standard ),
            ( "ダ", "da", Type.Standard ), ( "ヂ", "ji", Type.Standard ), ( "ヅ", "zu", Type.Standard ), ( "デ", "de", Type.Standard ), ( "ド", "do", Type.Standard ),
            ( "ナ", "na", Type.Standard ), ( "ニ", "ni", Type.Standard ), ( "ヌ", "nu", Type.Standard ), ( "ネ", "ne", Type.Standard ), ( "ノ", "no", Type.Standard ),
            ( "ハ", "ha", Type.Standard ), ( "ヒ", "hi", Type.Standard ), ( "フ", "fu", Type.Standard ), ( "ヘ", "he", Type.Standard ), ( "ホ", "ho", Type.Standard ),
            ( "バ", "ba", Type.Standard ), ( "ビ", "bi", Type.Standard ), ( "ブ", "bu", Type.Standard ), ( "ベ", "be", Type.Standard ), ( "ボ", "bo", Type.Standard ),
            ( "パ", "pa", Type.Standard ), ( "ピ", "pi", Type.Standard ), ( "プ", "pu", Type.Standard ), ( "ペ", "pe", Type.Standard ), ( "ポ", "po", Type.Standard ),
            ( "マ", "ma", Type.Standard ), ( "ミ", "mi", Type.Standard ), ( "ム", "mu", Type.Standard ), ( "メ", "me", Type.Standard ), ( "モ", "mo", Type.Standard ),
            ( "ヤ", "ya", Type.Standard ), ( "", "", Type.Standard ), ( "ユ", "yu", Type.Standard ), ( "", "", Type.Standard ), ( "ヨ", "yo", Type.Standard ),
            ( "ラ", "ra", Type.Standard ), ( "リ", "ri", Type.Standard ), ( "ル", "ru", Type.Standard ), ( "レ", "re", Type.Standard ), ( "ロ", "ro", Type.Standard ),
            ( "ワ", "wa", Type.Standard ), ( "ヰ", "wi", Type.Special ), ( "", "", Type.Standard ), ( "ヱ", "we", Type.Special ), ( "ヲ", "wo", Type.Standard ),
            ( "", "" , Type.Standard ), ( "", "", Type.Standard ), ( "ヴ", "vu", Type.Special ), ( "", "", Type.Standard ), ( "ン", "n", Type.Standard ),
        };

        // Size: 11 * 3
        public static readonly (string, string, Type)[] hiraganaCombDict =
        {
            ( "きゃ", "kya", Type.Standard ), ( "きゅ", "kyu", Type.Standard ), ( "きょ", "kyo", Type.Standard ),
            ( "ぎゃ", "gya", Type.Standard ), ( "ぎゅ", "gyu", Type.Standard ), ( "ぎょ", "gyo", Type.Standard ),
            ( "しゃ", "sha", Type.Standard ), ( "しゅ", "shu", Type.Standard ), ( "しょ", "sho", Type.Standard ),
            ( "じゃ", "ja", Type.Standard ),  ( "じゅ", "ju", Type.Standard ),  ( "じょ", "jo", Type.Standard ),
            ( "ちゃ", "cha", Type.Standard ), ( "ちゅ", "chu", Type.Standard ), ( "ちょ", "cho", Type.Standard ),
            ( "にゃ", "nya", Type.Standard ), ( "にゅ", "nyu", Type.Standard ), ( "にょ", "nyo", Type.Standard ),
            ( "ひゃ", "hya", Type.Standard ), ( "ひゅ", "hyu", Type.Standard ), ( "ひょ", "hyo", Type.Standard ),
            ( "びゃ", "bya", Type.Standard ), ( "びゅ", "byu", Type.Standard ), ( "びょ", "byo", Type.Standard ),
            ( "ぴゃ", "pya", Type.Standard ), ( "ぴゅ", "pyu", Type.Standard ), ( "ぴょ", "pyo", Type.Standard ),
            ( "みゃ", "mya", Type.Standard ), ( "みゅ", "myu", Type.Standard ), ( "みょ", "myo", Type.Standard ),
            ( "りゃ", "rya", Type.Standard ), ( "りゅ", "ryu", Type.Standard ), ( "りょ", "ryo", Type.Standard ),
        };

        public static readonly (string, string, Type)[] katakanaCombDict =
        {
            ( "キャ", "kya", Type.Standard ), ( "キュ", "kyu", Type.Standard ), ( "キョ", "kyo", Type.Standard ),
            ( "ギャ", "gya", Type.Standard ), ( "ギュ", "gyu", Type.Standard ), ( "ギョ", "gyo", Type.Standard ),
            ( "シャ", "sha", Type.Standard ), ( "シュ", "shu", Type.Standard ), ( "ショ", "sho", Type.Standard ),
            ( "ジャ", "ja", Type.Standard ),  ( "ジュ", "ju", Type.Standard ),  ( "ジョ", "jo", Type.Standard ),
            ( "チャ", "cha", Type.Standard ), ( "チュ", "chu", Type.Standard ), ( "チョ", "cho", Type.Standard ),
            ( "ニャ", "nya", Type.Standard ), ( "ニュ", "nyu", Type.Standard ), ( "ニョ", "nyo", Type.Standard ),
            ( "ヒャ", "hya", Type.Standard ), ( "ヒュ", "hyu", Type.Standard ), ( "ヒョ", "hyo", Type.Standard ),
            ( "ビャ", "bya", Type.Standard ), ( "ビュ", "byu", Type.Standard ), ( "ビョ", "byo", Type.Standard ),
            ( "ピャ", "pya", Type.Standard ), ( "ピュ", "pyu", Type.Standard ), ( "ピョ", "pyo", Type.Standard ),
            ( "ミャ", "mya", Type.Standard ), ( "ミュ", "myu", Type.Standard ), ( "ミョ", "myo", Type.Standard ),
            ( "リャ", "rya", Type.Standard ), ( "リュ", "ryu", Type.Standard ), ( "リョ", "ryo", Type.Standard ),
        };

        public static (string, string) PickRandom(bool enableHiragana, bool enableKatakana, bool enableCombination, bool enableSpecial)
        {
            int randMaximum = 0;
            if (enableHiragana) randMaximum += normDictCount;
            if (enableKatakana) randMaximum += normDictCount;
            if (enableHiragana && enableCombination) randMaximum += combDictCount;
            if (enableKatakana && enableCombination) randMaximum += combDictCount;

            Random rand = new Random();
            (string, string, Type) result = ("", "", Type.Standard);

            while (result.Item1 == "" || (result.Item3 == Type.Special && !enableSpecial))
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

            return (result.Item1, result.Item2);
        }
    }
}

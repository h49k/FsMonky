/// 駅名の情報を格納するデータ型
type ekimei_t = {
    kanji : string;    // 漢字の駅名
    kana : string;     // かな駅名
    romaji : string;   // ローマ字駅名
    shozoku : string;  // 所属路線名
}

/// ekimei_t のデータを受け取り「路線名, 駅名（かな）」の形式の文字列を返す。
//　hyouji : ekimei_t -> string
let hyouji ekimei = 
    match ekimei with
        {kanji = kj; kana = kn; romaji = r; shozoku = s} ->
        s + ", " + kj + "（" + kn + "）"

// テスト
let test_hyouji_1 = hyouji { kanji = "茗荷谷";
                             kana = "みょうがだに";
                             romaji = "myogadani";
                             shozoku = "丸ノ内線"} =
                           "丸ノ内線, 茗荷谷（みょうがだに）"
                           

/// 駅と駅の接続情報を格納する。
type ekikan_t = {
    kiten : string;   // 起点の駅名
    shuten : string;  // 終点の駅名
    keiyu : string;   // 経由する路線名
    kyori : float;    // 2駅間の距離
    jikan : int;      // 所要時間
}
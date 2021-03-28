/// 受け取った実数xの絶対値を計算する。
// abs_value : float -> float
let abs_value x = 
    if x > 0.0 then x
               else - x
      
// テスト
let test_abs_value_001 = abs_value 2.8 = 2.8
let test_abs_value_002 = abs_value -2.8 = 2.8
let test_abs_value_003 = abs_value 0.0 = 0.0


/// 現在の気温t から快適度を表す文字列を計算する
//  kion : int -> string
let kion t = 
    if 15 <= t && t <= 25 then "快適"
                          else "普通"

// テスト
let test_kion1 = kion  7 = "普通"
let test_kion2 = kion 15 = "快適"
let test_kion3 = kion 20 = "快適"
let test_kion4 = kion 25 = "快適"
let test_kion5 = kion 28 = "普通"

// Section.7

// Problem 7.2
/// 名前と成績の組を受け取ったら「〇〇さんの評価は△△です。」という文字列を返す。
//  seiseki : string * string -> string
let seiseki pair =
    match pair with
        (a, b) -> a + "さんの評価は" + b + "です。"

// テスト
let test_seiseki_001 = seiseki ("田中", "うんこ") = "田中さんの評価はうんこです。"

/// ふたつの整数の組 pair を受け取り要素の和を返す。
//　 add : int * int -> int
let add pair =
    match pair with
        (a, b) -> a + b

// テスト
let test_add_1 = add (0, 0) = 0
let test_add_2 = add (3, 5) = 8
let test_add_3 = add (3, -5) = -2

// Problem7.3
/// x座標とy座標の組で表された平面座標を受け取り、x軸について対象な点の座標を返す。
//  taisho_x : int * int -> int * int
let taisho_x coordinates = 
    match coordinates with
        (x, y) -> (- x, y)

let test_taisho_x_1 = taisho_x (0, 0) = (0, 0)
let test_taisho_x_2 = taisho_x (3, 5) = (-3, 5)
let test_taisho_x_3 = taisho_x (-1, 6) = (1, 6)


/// x座標とy座標の組で表された平面座標をふたつ受け取ったら、
/// その中点の座標を返す
//  chuten : float * float -> float * float -> float * float
let chuten coordinates1 coodinates2 =
    match (coordinates1, coodinates2) with
        (x1, y1), (x2, y2) -> ((x1 + x2) / 2.0 , (y1 + y2) / 2.0)

// テスト
let test_chuten_1 = chuten (-2.0 ,2.0) (2.0, -2.0) = (0.0, 0.0)
let test_chuten_2 = chuten (5.0 ,1.0) (1.0, 4.0) = (3.0, 2.5)
let test_chuten_3 = chuten (12.0 ,7.0) (-2.0, -2.0) = (5.0, 2.5)

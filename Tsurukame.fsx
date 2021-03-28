/// 目的: 鶴の数を与えると鶴の足の数を返す 
//  tsuru_no_ashi: int -> int
let tsuru_no_ashi tsuru = tsuru * 2

// テスト
let test_tsuru_no_ashi_001 = tsuru_no_ashi 4 = 8
let test_tsuru_no_ashi_002 = tsuru_no_ashi 0 = 0
let test_tsuru_no_ashi_003 = tsuru_no_ashi 7 = 14



/// 鶴と亀の数を与えると足の数の合計を返す
//  tsurukame_no_ashi : int -> int -> int
let tsurukame_no_ashi tsuru kame = tsuru_no_ashi tsuru + tsuru_no_ashi kame * 2
                       
// テスト
let test_tsurukame_no_ashi_001 = tsurukame_no_ashi 2 3 = 16
let test_tsurukame_no_ashi_002 = tsurukame_no_ashi 0 7 = 28
let test_tsurukame_no_ashi_003 = tsurukame_no_ashi 4 1 = 12


/// 鶴亀算を行う。鶴と亀の数の合計と鶴と亀の足の数の合計を与えられたら、鶴の数を返す。
//  tsurukame : int -> int -> int
let tsurukame atama ashi = (( atama * 4) - ashi) / 2 

// テスト
let test_tsurukame_001 = tsurukame 7 22 = 3
let test_tsurukame_002 = tsurukame 2 6 = 1
let test_tsurukame_003 = tsurukame 12 26 = 11

(* 目的: 身長mを与えられたら標準体重を返す *)
(* hyojun_taiju : float -> float *)
let hyojun_taiju m = m ** 2. * 22.

(* test *)
let test_hyojun_taiju_001 = hyojun_taiju 1.635 = 58.81095
let test_hyojun_taiju_002 = hyojun_taiju 1.427 = 44.799238


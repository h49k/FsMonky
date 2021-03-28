type gakusei_t =
    {
        namae: string;
        tensuu: int;
        seiseki: string;
    }

let asai = {namae="asai"; tensuu=70; seiseki="B"}

/// 学生の評価を返す。
//　hyouka : gakusei_t -> gakusei_t
let hyouka gakusei =
    match gakusei with
        {namae = n; tensuu = t; seiseki = s} ->
            if t >= 80 then      {namae = n; tensuu = t; seiseki = "A"}
            else if t >= 70 then {namae = n; tensuu = t; seiseki = "B"}
            else if t >= 60 then {namae = n; tensuu = t; seiseki = "C"}
            else                 {namae = n; tensuu = t; seiseki = "D"}

// テスト
let test_hyouka1 = hyouka {namae="asai"; tensuu=90; seiseki=""}
                        = {namae="asai"; tensuu=90; seiseki="A"}
let test_hyouka2 = hyouka {namae="asai"; tensuu=80; seiseki=""}
                        = {namae="asai"; tensuu=80; seiseki="A"}
let test_hyouka3 = hyouka {namae="asai"; tensuu=75; seiseki=""}
                        = {namae="asai"; tensuu=75; seiseki="B"}
let test_hyouka4 = hyouka {namae="asai"; tensuu=70; seiseki=""}
                        = {namae="asai"; tensuu=70; seiseki="B"}
let test_hyouka5 = hyouka {namae="asai"; tensuu=65; seiseki=""}
                        = {namae="asai"; tensuu=65; seiseki="C"}
let test_hyouka6 = hyouka {namae="asai"; tensuu=60; seiseki=""}
                        = {namae="asai"; tensuu=60; seiseki="C"}
let test_hyouka7 = hyouka {namae="asai"; tensuu=55; seiseki=""}
                        = {namae="asai"; tensuu=55; seiseki="D"}

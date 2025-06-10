using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_833 : SimTemplate //* 拉卡利地狱犬 Lakkari Felhound
	{
		//<b>Taunt</b><b>Battlecry:</b> Discard your two lowest-Cost cards.
		//<b>嘲讽</b>，<b>战吼：</b>弃掉你手牌中法力值消耗最低的两张牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            //TODO 弃牌待优化
            p.discardCards(2, own.own);
        }
    }
}

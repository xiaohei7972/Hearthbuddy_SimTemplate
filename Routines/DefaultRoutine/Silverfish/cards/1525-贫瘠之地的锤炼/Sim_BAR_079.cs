using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_079 : SimTemplate //* 魔像师卡扎库斯 Kazakus, Golem Shaper
	{
        //<b>Battlecry:</b> If your deck has no 4-Cost cards, build a custom Golem.
        //<b>战吼：</b>如果你的牌库里没有法力值消耗为（4）的牌，则为你制造一个自定义魔像。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, true, true);
        }

    }
}

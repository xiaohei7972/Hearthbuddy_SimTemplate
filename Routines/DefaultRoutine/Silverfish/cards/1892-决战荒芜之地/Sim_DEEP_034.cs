using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DEEP_034 : SimTemplate // Shale Spider
    {
        // <b>战吼：</b> 如果你在上个回合使用过元素牌，抽一张牌。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own);
		}

       
    }
}

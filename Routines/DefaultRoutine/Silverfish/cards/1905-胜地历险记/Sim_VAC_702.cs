using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：7 攻击力：6 生命值：6
	//Marin the Manager
	//经理马林
	//[x]<b>Battlecry:</b> Choose afantastic treasure.Shuffle the other 3into your deck.
	//<b>战吼：</b>选择一张神奇宝藏。将其余3张洗入你的牌库。
	class Sim_VAC_702 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 随机抽一张牌
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }
	}
}

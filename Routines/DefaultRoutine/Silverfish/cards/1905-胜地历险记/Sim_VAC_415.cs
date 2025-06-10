using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：7 攻击力：4 生命值：5
	//Sasquawk
	//大叫巨鹦萨考克
	//<b>Battlecry:</b> Repeat each card you played last turn.
	//<b>战吼：</b>重复你在上回合使用的每一张牌。
	class Sim_VAC_415 : SimTemplate
	{

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
        }
    }
}

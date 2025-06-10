using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 猎人 费用：3 攻击力：3 生命值：3
	//Chatty Macaw
	//话痨鹦鹉
	//[x]<b>Battlecry:</b> Repeat the lastspell you cast at an enemy<i>(at a random enemyif possible)</i>.
	//<b>战吼：</b><i>（尽可能对一个随机的敌人）</i>重新施放你对一个敌人施放的上一个法术。
	class Sim_VAC_407 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
        }

    }
}

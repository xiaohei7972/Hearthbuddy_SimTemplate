using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：1
	//Soulrest Ceremony
	//安魂仪典
	//[x]Give your minions+1 Attack and <b>Rush</b>. Theydie at the end of your turn.
	//使你的随从获得+1攻击力和<b>突袭</b>。它们会在你的回合结束时死亡。
	class Sim_DINO_417 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			foreach (Minion minion in ownplay ? p.ownMinions : p.enemyMinions)
			{
				p.minionGetBuffed(minion, 1, 0);
				p.minionGetRush(minion);
				//TODO:回合结束死亡之后再说
			}
        }
		
	}
}

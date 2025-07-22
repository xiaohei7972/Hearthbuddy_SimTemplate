using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：0
	//Vision of Heroes
	//英雄视界
	//Summon a random6-Cost minion. Give it <b>Taunt</b> and <b>Lifesteal</b>.
	//随机召唤一个法力值消耗为（6）的随从。使其获得<b>嘲讽</b>和<b>吸血</b>。
	class Sim_TTN_429t3 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.RemoveMinionWithoutDeathrattle(target); // 移出战场 待完善
            p.drawACard(CardDB.cardIDEnum.None, true);
        }
    }
}

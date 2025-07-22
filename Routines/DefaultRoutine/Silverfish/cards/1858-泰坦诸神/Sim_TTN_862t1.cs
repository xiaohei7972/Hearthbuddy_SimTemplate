using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：0
	//Crystal Carving
	//雕琢晶石
	//[x]<b>Discover</b> a <b>Deathrattle</b>minion. It costs (3) less.
	//<b>发现</b>一张<b>亡语</b>随从牌，其法力值消耗减少（3）点。
	class Sim_TTN_862t1 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, true); // 发现一张亡语随从牌
            p.owncards.Skip(Math.Max(0, p.owncards.Count - 1)).ToList().ForEach(handCard =>
            {
                handCard.manacost -= 3;
            });
        }
    }
}

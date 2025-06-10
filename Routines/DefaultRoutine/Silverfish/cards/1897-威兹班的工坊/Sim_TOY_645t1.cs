using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 恶魔猎手 费用：2
	//Greater Opal Spellstone
	//大型法术欧珀石
	//Draw 3 cards.
	//抽三张牌。
	class Sim_TOY_645t1 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 抽三张牌
            for (int i = 0; i < 3; i++)
            {
                p.drawACard(CardDB.cardIDEnum.None, ownplay);
            }
        }

    }
}

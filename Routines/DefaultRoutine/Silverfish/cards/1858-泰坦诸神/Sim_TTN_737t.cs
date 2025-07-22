using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：0
	//Runes of Blood
	//鲜血符文
	//Destroy an enemy minion. This minion and your hero gain its Health.
	//消灭一个敌方随从。本随从和你的英雄获得其生命值。
	class Sim_TTN_737t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (target != null)
            {
                p.minionGetDestroyed(target);
                p.ownMinions.Where(m => m.handcard.card.cardIDenum == CardDB.cardIDEnum.TTN_415).ToList().ForEach(m =>
                {
                    m.Hp += target.Hp;
                });
                p.ownHero.Hp += target.Hp;
                p.drawACard(CardDB.cardIDEnum.None, true, true);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),        // 需要选择目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),          // 目标必须是随从
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET)            // 目标必须是敌方随从
            };
        }
    }
}

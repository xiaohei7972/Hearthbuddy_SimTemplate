using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：7 攻击力：7 生命值：7
	//Ancient of Lore
	//知识古树
	//<b>Choose One -</b> Draw 2 cards; or Restore #7 Health.
	//<b>抉择：</b>抽两张牌；或者恢复#7点生命值。
	class Sim_CORE_NEW1_008 : SimTemplate
	{
		public override void onCardPlay(Playfield p, Minion own, Minion target, int choice)
        {

            if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
            {
                p.drawACard(CardDB.cardIDEnum.None, own.own);
                p.drawACard(CardDB.cardIDEnum.None, own.own);
            }

            if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
            {
                if (target != null)
                {
                    int heal = (own.own) ? p.getMinionHeal(7) : p.getEnemyMinionHeal(7);
                    p.minionGetDamageOrHeal(target, -heal);
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
            };
        }
		
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 猎人 费用：2
	//Conjured Arrow
	//咒术之箭
	//Deal $2 damageto a minion.<b>Manathirst (6):</b> Drawthat many cards.
	//对一个随从造成$2点伤害。<b>法力渴求（6）：</b>抽取相同数量的牌。
	class Sim_RLK_804 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
            p.minionGetDamageOrHeal(target, dmg);

			for  (int i=0; i<dmg; i++) {
				p.drawACard(CardDB.cardIDEnum.None, ownplay);
			}
		}
		
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
		
		
	}
}

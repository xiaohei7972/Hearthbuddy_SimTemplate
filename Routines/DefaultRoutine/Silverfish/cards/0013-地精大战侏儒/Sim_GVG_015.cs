using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //法术 术士 费用：2
	//Darkbomb
	//暗色炸弹
	//Deal $3 damage to a character. If it dies, draw a Shadow spell.
	//对一个角色造成$3点伤害。如果该角色死亡，抽一张暗影法术牌。
    class Sim_GVG_015
        : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                int Damage = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
                p.minionGetDamageOrHeal(target, Damage);
                if (target.Hp <= 0)
                {
                    //TODO:这里写的不对,没有判断是不是暗影法术,懒得写了之后再改
                    List<CardDB.cardIDEnum> card =  p.CheckTurnDeckForType(CardDB.cardtype.SPELL, 1);
                    if (card.Count != 0)
                    {
                        p.drawACard(card[0], ownplay);
                    }
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), //只能是敌方
            };
        }
    }

}
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 斩棘刀 Vinecleaver
    //[x]After your hero attacks,summon two 1/1 SilverHand Recruits.
    //在你的英雄攻击后，召唤两个1/1的白银之手新兵。
    class Sim_UNG_950 : SimTemplate
    {
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_950);
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
        //英雄攻击
        public override void afterHeroattack(Playfield p, Minion own, Minion target)
        {
            // 检查己方英雄是否装备了“斩棘刀”
            if (own.own && p.ownWeapon.card.cardIDenum == CardDB.cardIDEnum.UNG_950)
            {
                // 获取位置	
                int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
                // 召唤白银之手新兵
                p.callKid(kid, pos, own.own);
                p.callKid(kid, pos, own.own);
            }
        }

    }
}
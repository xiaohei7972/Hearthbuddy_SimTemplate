using System;
using System.Collections.Generic;
using System.Text;
using Triton.Game.Mapping;

namespace HREngine.Bots
{
	//法术 猎人 费用：0
	//Swift Slash
	//迅疾挥剑
	//[x]Give your weapon +2Attack and "Your hero is<b>Immune</b> while attacking."
	//使你的武器获得+2攻击力和“你的英雄在攻击时<b>免疫</b>。”
	class Sim_TTN_092t3 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.ownWeapon.Durability > 0)
            {
                Entity entity = GameState.Get().GetFriendlySidePlayer().GetHero();
                var creator = entity.GetTag(GAME_TAG.CREATOR);
                var cpyDeath = entity.GetTag(GAME_TAG.COPY_DEATHRATTLE);
                var ctrlId = entity.GetTag(GAME_TAG.CONTROLLER);
                p.ownWeapon.enchants.Add(new miniEnch(CardDB.cardIDEnum.TTN_092t3, creator, ctrlId, cpyDeath, entity));
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_WEAPON_EQUIPPED)  // 需要装备武器
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Triton.Game.Mapping;

namespace HREngine.Bots
{
	//法术 猎人 费用：0
	//Commanding Presence
	//统帅风范
	//Give your weapon"After your hero attacks,summon a 3/3 Enforcer with <b>Taunt</b>."
	//使你的武器获得“在你的英雄攻击后，召唤一个3/3并具有<b>嘲讽</b>的执行者。”
	class Sim_TTN_092t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.ownWeapon.Durability > 0)
            {
                Entity entity = GameState.Get().GetFriendlySidePlayer().GetHero();
                var creator = entity.GetTag(GAME_TAG.CREATOR);
                var cpyDeath = entity.GetTag(GAME_TAG.COPY_DEATHRATTLE);
                var ctrlId = entity.GetTag(GAME_TAG.CONTROLLER);
                p.ownWeapon.enchants.Add(new miniEnch(CardDB.cardIDEnum.TTN_092t2, creator, ctrlId, cpyDeath, entity));
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

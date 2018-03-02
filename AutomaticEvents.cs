using System;
using System.Collections.Generic;
using System.Text;
using Oxide.Core.Database;
using Oxide.Core.Libraries.Covalence;
using UnityEngine;
using System.Collections;
using Oxide.Core;
using UnityEngine.Scripting;
using System.Linq;

namespace Oxide.Plugins
{
    [Info("AutomaticEvents", "531devv (531devv@gmail.com)", "1.0.0")]
    [Description("Automatic events for Hurtworld.")]

    class AutomaticEvents : HurtworldPlugin
    {
        public static GameObject gameObject;

        void Loaded()
        {
            timer.Repeat(18000f, 0, () =>
            {
                var allPlayers = GameManager.Instance.GetSessions().Values.ToList();
                if (allPlayers.Count() < 10)
                {
                    hurt.BroadcastChat(null, "Za malo graczy, evencik loteria przepada! :(");
                }
                else if ((allPlayers.Count() >= 10) && (allPlayers.Count() <= 20))
                {
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 20) && (allPlayers.Count() <= 30))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 30) && (allPlayers.Count() <= 40))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 40) && (allPlayers.Count() <= 50))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 50) && (allPlayers.Count() <= 60))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 60) && (allPlayers.Count() <= 70))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 70) && (allPlayers.Count() <= 80))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 80) && (allPlayers.Count() <= 90))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 90) && (allPlayers.Count() <= 100))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
            });
        }

        void StartLotteryEvent()
        {
            var ItemMgr = Singleton<GlobalItemManager>.Instance;
            var allPlayers = GameManager.Instance.GetSessions().Values.ToList();
            if (allPlayers.Count() > 0)
            {
                int randomInt = UnityEngine.Random.Range(0, allPlayers.Count());
                var playerId = allPlayers[randomInt].SteamId;
                var playerName = allPlayers[randomInt].Name;
                var playerN = Player.FindById(playerId.ToString()).Player;

                int randomItemInt = UnityEngine.Random.Range(0, 4);

                ItemMgr.GiveItem(playerN, ItemMgr.GetItem(231), 2);
                Puts("Lottery Event starting..");
                hurt.BroadcastChat(null, "<color=#ff0000ff>[Loteria Event]</color>: " + playerName + " wygral <color=#00ff00ff>2x Detonatory!</color>");
            }
        }

        void StartAlbinoEvent()
        {
            SpawnObject("AITokarAlbinoServer", -3319, 197, -1506);
            SpawnObject("AITokarAlbinoServer", -2308, 195, -997);
            SpawnObject("AITokarAlbinoServer", 1486, 192, -1946);
            SpawnObject("AITokarAlbinoServer", 1170, 192, -3366);
            SpawnObject("AITokarAlbinoServer", -2605, 170, 1626);
            SpawnObject("AITokarAlbinoServer", -1250, 172, 1185);

            SpawnObject("AIYetiServer", -3319, 197, -1506);
            SpawnObject("AIYetiServer", -2308, 195, -997);
            SpawnObject("AIYetiServer", 1486, 192, -1946);
            SpawnObject("AIYetiServer", 1170, 192, -3366);
            SpawnObject("AIYetiServer", -2605, 170, 1626);
            SpawnObject("AIYetiServer", -1250, 172, 1185);
            SpawnObject("AIYetiServer", -3319, 197, -1506);
            SpawnObject("AIYetiServer", -2308, 195, -997);
            SpawnObject("AIYetiServer", 1486, 192, -1946);
            SpawnObject("AIYetiServer", 1170, 192, -3366);
            SpawnObject("AIYetiServer", -2605, 170, 1626);
            SpawnObject("AIYetiServer", -1250, 172, 1185);
            Puts("Albino event starting..");

            hurt.BroadcastChat(null, "Albinosy <color=#008080ff>wykluwają się z jajek!</color>");
            hurt.BroadcastChat(null, "Masz godzinę,<color=#008080ff> zabij je i zdobądź łup!</color>");
            hurt.BroadcastChat(null, "Hangary,<color=#008080ff> tam je znajdziesz!</color>");
        }

        [ChatCommand("loteria")]
        void lotteryEvent(PlayerSession player, string command, string[] args)
        {
            if (player.IsAdmin)
            {
                var allPlayers = GameManager.Instance.GetSessions().Values.ToList();
                if (allPlayers.Count() < 10)
                {
                    hurt.BroadcastChat(null, "Za malo graczy, evencik przepada! :(");
                }
                else if ((allPlayers.Count() >= 10) && (allPlayers.Count() <= 20))
                {
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 20) && (allPlayers.Count() <= 30))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 30) && (allPlayers.Count() <= 40))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 40) && (allPlayers.Count() <= 50))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 50) && (allPlayers.Count() <= 60))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 60) && (allPlayers.Count() <= 70))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 70) && (allPlayers.Count() <= 80))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 80) && (allPlayers.Count() <= 90))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
                else if ((allPlayers.Count() >= 90) && (allPlayers.Count() <= 100))
                {
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                    StartLotteryEvent();
                }
            }
            else
            {
                hurt.SendChatMessage(player, null, "Nie jesteś adminem kurwo opluta!");
            }
        }

        [ChatCommand("albinosy")]
        void albinoEvent(PlayerSession player, string command, string[] args)
        {
            if (player.IsAdmin)
            {
                StartAlbinoEvent();
            }
            else
            {
                hurt.SendChatMessage(player, null, "Nie jesteś adminem kurwo opluta!");
            }
        }

        #region Helpers


        public void SpawnObject(string monster, float x, float y, float z)
        {
            Vector3 position = new Vector3(x + Core.Random.Range(0, 2),
                    y + Core.Random.Range(0, 2),
                    z + Core.Random.Range(0, 1));
            RaycastHit hitInfo;
            Physics.Raycast(position, Vector3.down, out hitInfo);
            {
                Quaternion rotation = Quaternion.Euler(0.0f, (float)UnityEngine.Random.Range(0f, 360f), 0.0f);
                rotation = Quaternion.FromToRotation(Vector3.down, hitInfo.normal) * rotation;
                gameObject = Singleton<HNetworkManager>.Instance.NetInstantiate(monster, hitInfo.point, Quaternion.identity, GameManager.GetSceneTime());
                Destroy(gameObject);
            }
        }

        void Destroy(GameObject obj)
        {
            timer.Once(3600, () =>
            {
                Singleton<HNetworkManager>.Instance.NetDestroy(uLink.NetworkView.Get(obj));
            });
        }

        #endregion


    }
}

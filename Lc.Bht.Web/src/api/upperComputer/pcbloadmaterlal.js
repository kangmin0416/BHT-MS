import request from "@/utils/request";

///主板上料
export function pcbLoadMaterla(data) {
  return request({
    url: "Api/PcbLoadMaterlal/PcbLoadMaterla",
    method: "post",
    data
  });
}

//主板上料历史记录
export function GetHistory(data) {
  return request({
    url: "Api/PcbLoadMaterlal/GetHistory",
    method: "post",
    data
  });
}

export default { pcbLoadMaterla, GetHistory };

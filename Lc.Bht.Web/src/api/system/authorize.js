import request from '@/utils/request'

export function GetAllRelationTree() {
  return request({
    url: 'api/Authorize/GetRelationTree',
    method: 'get'
  })
}

export function GetRelationTree(userID) {
  return request({
    url: 'api/Authorize/GetRelationTree?userID=' + userID,
    method: 'get'
  })
}

export function UpdateUserRelation(data) {
  return request({
    url: 'api/Authorize/UpdateUserRelation',
    method: 'post',
    data
  })
}

export default { GetRelationTree, UpdateUserRelation, GetAllRelationTree }

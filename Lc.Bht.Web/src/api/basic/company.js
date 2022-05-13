import request from '@/utils/request'

export function queryCompany(data) {
  return request({
    url: 'api/company/query',
    method: 'post',
    data
  })
}

export function getCompany(id) {
  return request({
    url: 'api/company/get?id=' + id,
    method: 'get'
  })
}

export function getAllCompany(enable) {
  return request({
    url: 'api/company/getAll' + (enable === undefined ? '' : ('?enable=' + enable)),
    method: 'get'
  })
}

export function createCompany(data) {
  return request({
    url: 'api/company/create',
    method: 'post',
    data
  })
}

export function updateCompany(data) {
  return request({
    url: 'api/company/update',
    method: 'post',
    data
  })
}

export function deleteCompany(id) {
  return request({
    url: 'api/company/delete?id=' + id,
    method: 'get'
  })
}

export default { queryCompany, getCompany, getAllCompany, createCompany, updateCompany, deleteCompany }

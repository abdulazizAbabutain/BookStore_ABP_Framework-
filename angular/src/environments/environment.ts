import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'BookStoreLap',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44325',
    redirectUri: baseUrl,
    clientId: 'BookStoreLap_App',
    responseType: 'code',
    scope: 'offline_access BookStoreLap',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44325',
      rootNamespace: 'BookStoreLap',
    },
  },
} as Environment;
